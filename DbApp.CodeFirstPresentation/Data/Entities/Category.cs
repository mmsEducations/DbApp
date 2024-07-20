using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbApp.CodeFirstPresentation.Data.Entities
{
    [Table("Categories")]
    internal class Category
    {
        [Column("category_id")]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(100)]
        [Column("name")]
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }//Category to Products : Bire Çok ilişki  Navigation Property
    }
}
