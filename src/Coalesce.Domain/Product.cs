using System;
using System.ComponentModel.DataAnnotations.Schema;
using IntelliTect.Coalesce.DataAnnotations;

namespace Coalesce.Domain
{
    [Table("Product")]
    [Create(Roles = "Admin")]
    [Edit(Roles = "Admin")]
    public class Product
    {
        public int ProductId { get; set; }

        [Search(SearchMethod = SearchAttribute.SearchMethods.Contains)]
        public string Name { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }

        [Column("ProductUniqueId")]
        public Guid UniqueId { get; set; }
    }
}