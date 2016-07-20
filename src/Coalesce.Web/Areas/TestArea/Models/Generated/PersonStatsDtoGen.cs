
using System;
using System.Collections.Generic;
using System.Security.Claims;
using IntelliTect.Coalesce.Interfaces;
using IntelliTect.Coalesce.Models;
using IntelliTect.Coalesce.Mapping;
using System.Linq;
using Newtonsoft.Json;
// Model Namespaces
    using Coalesce.Domain;
    using Coalesce.Domain.External;
using static Coalesce.Domain.PersonStats;

namespace Coalesce.Web.TestArea.Models
{
    public partial class PersonStatsDtoGen : GeneratedDto<PersonStats, PersonStatsDtoGen>
        , IClassDto<PersonStats, PersonStatsDtoGen>
        {
        public PersonStatsDtoGen() { }

             public Int32? PersonStatsId { get; set; }
             public Double? Height { get; set; }
             public Double? Weight { get; set; }
             public PersonLocation PersonLocation { get; set; }

        // Create a new version of this object or use it from the lookup.
        public static PersonStatsDtoGen Create(PersonStats obj, ClaimsPrincipal user = null, string includes = null,
                                   Dictionary<object, object> objects = null) {
            // Return null of the object is null;
            if (obj == null) return null;
                        
            if (objects == null) objects = new Dictionary<object, object>();

            includes = includes ?? "";

            // Applicable includes for PersonStats
            

            // Applicable excludes for PersonStats
            

            // Applicable roles for PersonStats
            if (user != null)
			{
			}



            // See if the object is already created.
            if (objects.ContainsKey(obj)) 
                return (PersonStatsDtoGen)objects[obj];

            var newObject = new PersonStatsDtoGen();
            objects.Add(obj, newObject);
            // Fill the properties of the object.
            newObject.PersonStatsId = obj.PersonStatsId;
            newObject.Height = obj.Height;
            newObject.Weight = obj.Weight;
            newObject.PersonLocation = obj.PersonLocation;
            return newObject;
        }

        // Instance constructor because there is no way to implement a static interface in C#. And generic constructors don't take arguments.
        public PersonStatsDtoGen CreateInstance(PersonStats obj, ClaimsPrincipal user = null, string includes = null,
                                Dictionary<object, object> objects = null) {
            return Create(obj, user, includes, objects);
        }

        // Updates an object from the database to the state handed in by the DTO.
        public void Update(PersonStats entity, ClaimsPrincipal user = null, string includes = null)
        {
            includes = includes ?? "";

            if (OnUpdate(entity, user, includes)) return;

            // Applicable includes for PersonStats
            

            // Applicable excludes for PersonStats
            

            // Applicable roles for PersonStats
            if (user != null)
			{
			}

			entity.Height = (Double)(Height ?? 0);
			entity.Weight = (Double)(Weight ?? 0);
        }

        public void SecurityTrim(ClaimsPrincipal user = null, string includes = null)
        {
        if (OnSecurityTrim(user, includes)) return;

        // Applicable includes for PersonStats
        

        // Applicable excludes for PersonStats
        

        // Applicable roles for PersonStats
        if (user != null)
			{
			}

        }
        }
        }