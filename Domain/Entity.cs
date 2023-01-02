namespace Aplicativo_de_Pedido.Domain
{
    public abstract class Entity
    {
        public Entity()
        {
            Id= Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Createdby { get; set; }
        public DateTime CreatedOn { get; set; }
        public String Editedby { get; set; }
        public DateTime EditedOn { get; set; }
    }
}
