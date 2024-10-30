namespace SupermarketEF.Models
{
    public class Category
    {

        public int Id { get; set; } // Sera la llave primaria

        public string Name { get; set; }

        public string? Description { get; set; }

        public ICollection<Product> Products { get; set; } // Propieda de navegacion

    }
}