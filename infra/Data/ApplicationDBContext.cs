using Aplicativo_de_Pedido.Domain.Products;
using Flunt.Notifications;
using Microsoft.EntityFrameworkCore;
namespace Aplicativo_de_Pedido.infra.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { } 

        protected override void OnModelCreating(ModelBuilder builder) 
        {
            builder.Ignore<Notification>();
            
            builder.Entity<Product>()  //Criando parâmetro para o Product onde o nome se torna obrigatório
                .Property(p => p.Name).IsRequired();
            builder.Entity<Product>() // Criando parâmetro para o Product onde a Descriptio só pode ter o máximo de 255 caracteres  
                .Property(p => p.Description).HasMaxLength(255);
            builder.Entity<Category>() //Criando parâmetro para o Description onde o nome se torna obrigatório
                .Property(p => p.Name).IsRequired();
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configuration) //Criando uma configuração padrão para onde for String no banco de dados o máximo de caracteres será 100
        {
            configuration.Properties<String>()
                .HaveMaxLength(100);
        }
    }
}
