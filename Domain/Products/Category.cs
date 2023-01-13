using Flunt.Validations;

namespace Aplicativo_de_Pedido.Domain.Products
{
    public class Category : Entity
    {
        public String Name { get; set; }
        public bool Active { get; set; }

        public Category(string name, string createdBy, string editedBy)
        {
            var contract = new Contract<Category>()
                .IsNotNullOrEmpty(name, "Name")
                .IsNotNullOrEmpty(createdBy, "CreatedBy")
                .IsNotNullOrEmpty(editedBy, "Editedby");
            AddNotifications(contract);
            
            Name= name;
            Active= true;
            Createdby = createdBy;
            Editedby= editedBy;
            CreatedOn = DateTime.Now;
            EditedOn = DateTime.Now;

        }
    }
}
