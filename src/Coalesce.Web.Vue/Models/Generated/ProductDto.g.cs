using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Security.Claims;

namespace Coalesce.Web.Vue.Models
{
    public partial class ProductDtoGen : GeneratedDto<Coalesce.Domain.Product>
    {
        public ProductDtoGen() { }

        public int? ProductId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public System.Guid? UniqueId { get; set; }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(Coalesce.Domain.Product obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            // Fill the properties of the object.

            this.ProductId = obj.ProductId;
            this.Name = obj.Name;
            this.Address = obj.Address;
            this.City = obj.City;
            this.State = obj.State;
            this.PostalCode = obj.PostalCode;
            this.UniqueId = obj.UniqueId;
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(Coalesce.Domain.Product entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            entity.ProductId = (ProductId ?? entity.ProductId);
            entity.Name = Name;
            entity.Address = Address;
            entity.City = City;
            entity.State = State;
            entity.PostalCode = PostalCode;
            entity.UniqueId = (UniqueId ?? entity.UniqueId);
        }
    }
}
