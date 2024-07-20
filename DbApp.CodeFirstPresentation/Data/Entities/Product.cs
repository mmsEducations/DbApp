using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbApp.CodeFirstPresentation.Data.Entities
{
    [Table("Products")]
    internal class Product
    {
        [Column("product_id", Order = 1)]
        [Key]
        public int ProductId { get; set; }

        [Required]
        [StringLength(100)]
        //[MaxLength(100)]
        [Column("name", Order = 2)]
        public string Name { get; set; }

        [Column("price", TypeName = "decimal(18,2)", Order = 3)]
        public decimal Price { get; set; }

        [Column("crea_date", TypeName = "DateTime2", Order = 4)]
        public DateTime CreaDate { get; set; }

        [NotMapped]
        public int Count { get; set; }

        [Column("is_ative", Order = 5)]
        public bool IsActive { get; set; }

        [ForeignKey("Category")]//Kategoriden gelen bu alan Foreign key olur
        [Column("category_id")]
        public int CategoryId { get; set; } //Foreign key bağlantısını sağlar 
        public Category Category { get; set; } //Product to Category : Bire bir ilişki  Navigation Property
    }
}
//[xyz] : xyz bir attribute 
//enitity içinde içinde olunca buna data annotation denir 