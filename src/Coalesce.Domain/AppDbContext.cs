using IntelliTect.Coalesce;
using Microsoft.EntityFrameworkCore;

namespace Coalesce.Domain
{
    [Coalesce]
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Case> Cases { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CaseProduct> CaseProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}