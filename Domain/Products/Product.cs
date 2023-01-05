namespace Aplicativo_de_Pedido.Domain.Products
{
    public class Product : Entity
    {
        public String Name { get; set;}
        public Guid CategoryId { get; set;}
        public Category Category { get; set;}
        public String Description { get; set;}
        public bool HasStock { get; set; }
        public bool Active { get; set; } = true;

    }
}
