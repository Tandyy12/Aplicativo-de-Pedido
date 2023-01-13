using Aplicativo_de_Pedido.Domain.Products;
using Aplicativo_de_Pedido.infra.Data;

namespace Aplicativo_de_Pedido.Endpoints.Categories
{
    public class CategoryGetAll
    {
        public static String Tamplate => "/Categories";
        public static String[] Methods => new String[] { HttpMethod.Get.ToString() };
        public static Delegate Handle => Action;

        public static IResult Action(ApplicationDbContext context) 
        {
            var categories = context.Categories.ToList();
            var response = categories.Select(c => new CategoryResponse { Name = c.Name, Active = c.Active, id = c.Id});
            return Results.Ok(response);
        }
    }
}
