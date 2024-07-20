namespace DbApp.CodeFirstFluentApiPresentation.Data.Entities
{
    internal class Category
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }//Category to Products : Bire Çok ilişki  Navigation Property
    }
}
