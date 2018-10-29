using System;
using System.ComponentModel.DataAnnotations;
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
        [MaxLength(200)]
        [StringLength(200)]
        [Required]
        public string Name { get; set; }

        [MaxLength(200)]
        [StringLength(200)]
        public string Address { get; set; }

        [MaxLength(100)]
        [StringLength(100)]
        public string City { get; set; }

        [MaxLength(50)]
        [StringLength(50)]
        public string State { get; set; }

        [MaxLength(50)]
        [StringLength(50)]
        public string PostalCode { get; set; }

        [Column("ProductUniqueId")]
        public Guid UniqueId { get; set; }
    }
}