using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Bogus;
using Bogus.DataSets;
using Microsoft.EntityFrameworkCore;

namespace Coalesce.Domain
{
    public static class SampleData
    {
        private static readonly Random Random = new Random();

        private static readonly string[] ProductNames =
            {"Office", "Word", "Excel", "Visual Studio", "Visual Studio 2013", "Visual Studio 2015"};


        private static byte[][] GetImages()
        {
            using (var client = new HttpClient())
            {
                var imageFaker = new Internet();
                return Task.WhenAll(Enumerable.Repeat(client.GetByteArrayAsync(imageFaker.Avatar()), 10))
                    .ConfigureAwait(false).GetAwaiter().GetResult();
            }
        }

        public static void Initialize(AppDbContext context, int randomSeed = 1)
        {
            Randomizer.Seed = new Random(randomSeed == 1 ? new Random().Next() : randomSeed);

            try
            {
                context.Database.Migrate();
            }
            catch (InvalidOperationException e) when (e.Message ==
                                                      "No service for type 'Microsoft.EntityFrameworkCore.Migrations.IMigrator' has been registered."
            )
            {
                // this exception is expected when using an InMemory database
            }

            if (!context.Companies.Any())
            {
                Faker<Company> faker = new Faker<Company>()
                    .RuleFor(c => c.Address1, f => f.Address.StreetAddress())
                    .RuleFor(c => c.Address2, f => f.Address.StreetAddress())
                    .RuleFor(c => c.City, f => f.Address.City())
                    .RuleFor(c => c.Name, f => f.Company.CompanyName())
                    .RuleFor(c => c.State, f => f.Address.State())
                    .RuleFor(c => c.ZipCode, f => f.Address.ZipCode());

                context.Companies.AddRange(faker.Generate(10));
                context.SaveChanges();
            }

            if (!context.People.Any())
            {
                byte[][] images = GetImages();
                Faker<Person> faker = new Faker<Person>().RuleFor(p => p.BirthDate, f => f.Person.DateOfBirth)
                    .RuleFor(p => p.Email, f => f.Person.Email)
                    .RuleFor(p => p.FirstName, f => f.Person.FirstName)
                    .RuleFor(p => p.LastName, f => f.Person.LastName)
                    .RuleFor(p => p.Gender, f => f.PickRandom<Person.Genders>())
                    .RuleFor(p => p.LastBath, f => f.Date.Past())
                    .RuleFor(p => p.NextUpgrade, f => f.Date.Future())
                    .RuleFor(p => p.CompanyId, f => f.Random.Int(1, 10))
                    .RuleFor(p => p.Title, f => f.PickRandom<Person.Titles>())
                    .RuleFor(p => p.ProfilePic, f => f.PickRandom(images));

                context.People.AddRange(faker.Generate(100));
                context.SaveChanges();
            }

            if (!context.Products.Any())
            {
                var nameIndex = 0;

                Faker<Product> faker = new Faker<Product>()
                    .RuleFor(p => p.Name, () => ProductNames[nameIndex++])
                    .RuleFor(p => p.UniqueId, f => f.Random.Guid())
                    .RuleFor(p => p.Address, f => f.Address.StreetAddress())
                    .RuleFor(p => p.City, f => f.Address.City())
                    .RuleFor(p => p.PostalCode, f => f.Address.ZipCode())
                    .RuleFor(p => p.State, f => f.Address.State());

                context.Products.AddRange(faker.Generate(6));
                context.SaveChanges();
            }

            if (!context.Cases.Any())
            {
                string[] severities = {"Low", "Medium", "High", "Critical"};
                string[] titlePhrases =
                {
                    "Issue with {0}", "Problem with {0}", "{0} is broken", "{0} doesn't work", "HELP FIX {0} ASAP"
                };

                // I'm having fun, OK?
                string[] descPhrases =
                {
                    "It just worked yesterday why did you guys break it?",
                    "I didn't do anything to it, I swear! It broke right in front of my eyes!",
                    "I got an error message. What's your fax number so I can send you the Polaroid I took of it?",
                    "please fix asap",
                    "doesn't work anymore",
                    "",
                    "Everything works great!",
                    "I was working last night and my cat jumped on my desk but then the doorbell rang and it was the " +
                    "mailman but the package was damaged so I didnt sign for it but we chatted for a while about the neighbor's new dog " +
                    "and then I was hungry so I went and made this really good casserole that my mother used to make for " +
                    "dinner and then when I went back to my desk my cat was sleeping on the keyboard and I lost all my documents. Fix please?"
                };

                Faker<Case> faker = new Faker<Case>()
                    .RuleFor(c => c.Title, f => string.Format(f.PickRandom(titlePhrases), f.PickRandom(ProductNames)))
                    .RuleFor(c => c.Description, f => f.PickRandom(descPhrases))
                    .RuleFor(c => c.Severity, f => f.PickRandom(severities))
                    .RuleFor(c => c.ReportedById, f => f.Random.Int(11, 100))
                    .RuleFor(c => c.AssignedToId, f => f.Random.Int(1, 10))
                    .RuleFor(c => c.DevTeamAssignedId, f => f.Random.Int(0))
                    .RuleFor(c => c.Status, f => f.PickRandom<Case.Statuses>())
                    .RuleFor(c => c.OpenedAt, f => f.Date.Recent(30))
                    .RuleFor(c => c.CaseProducts, f => new List<CaseProduct>
                    {
                        new CaseProduct {ProductId = f.Random.Int(1, 6)}
                    });

                context.Cases.AddRange(faker.Generate(20));
                context.SaveChanges();
            }
        }
    }
}