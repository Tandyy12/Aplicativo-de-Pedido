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
            return Results.Ok("Ok");
        }
    }
}
