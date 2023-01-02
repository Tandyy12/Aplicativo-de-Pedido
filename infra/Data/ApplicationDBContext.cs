using Aplicativo_de_Pedido.Domain.Products;
using Microsoft.EntityFrameworkCore;
namespace Aplicativo_de_Pedido.infra.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { } 

        protected override void OnModelCreating(ModelBuilder builder) 
        {
            builder.Entity<Product>()
                .Property(p => p.Name).IsRequired();
            builder.Entity<Product>()
                .Property(p => p.Description).HasMaxLength(255);
            builder.Entity<Category>()
                .Property(p => p.Name).IsRequired();
        }

        protected override void ConfigureConventios(ModelConfigurationBuilder configuration) 
        {
            configuration.Properties<String>()
                .HaveMaxLength(100);
        }
    }
}
