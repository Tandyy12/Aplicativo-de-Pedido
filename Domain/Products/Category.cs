namespace Aplicativo_de_Pedido.Domain.Products
{
    public class Category : Entity
    {
        public String Name { get; set; }
        public bool Active { get; set; } = true;
    }
}
