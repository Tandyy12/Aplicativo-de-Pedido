using Aplicativo_de_Pedido.Domain.Products;
using Aplicativo_de_Pedido.infra.Data;

namespace Aplicativo_de_Pedido.Endpoints.Categories
{
    public class CategoryPost
    {
        public static String Tamplate => "/Categories";
        public static String[] Methods => new String[] { HttpMethod.Post.ToString() };
        public static Delegate Handle => Action;

        public static IResult Action(CategoryRequest categoryRequest, ApplicationDbContext context) 
        {
            var category = new Category
            {
                Name = categoryRequest.Name,
                Createdby = "Teste",
                CreatedOn= DateTime.Now,
                Editedby="Test",
                EditedOn= DateTime.Now,
            };
            context.Categories.Add(category);
            context.SaveChanges();
            return Results.Created($"/Categories/{category.Id}", category.Id);
        }
    }
}
