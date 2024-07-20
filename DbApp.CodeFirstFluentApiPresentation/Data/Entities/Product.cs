namespace DbApp.CodeFirstFluentApiPresentation.Data.Entities
{
    internal class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public DateTime CreaDate { get; set; }

        public int Count { get; set; }

        public bool IsActive { get; set; }

        public int CategoryId { get; set; } //Foreign key bağlantısını sağlar 
        public Category Category { get; set; } //Product to Category : Bire bir ilişki  Navigation Property
    }
}
//[xyz] : xyz bir attribute 
//enitity içinde içinde olunca buna data annotation denir 