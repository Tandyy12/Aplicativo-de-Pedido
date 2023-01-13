using Aplicativo_de_Pedido.Domain.Products;
using Aplicativo_de_Pedido.infra.Data;
using Microsoft.AspNetCore.Mvc;

namespace Aplicativo_de_Pedido.Endpoints.Categories
{
    public class CategoryPut
    {
        public static String Tamplate => "/Categories/{id}";
        public static String[] Methods => new String[] { HttpMethod.Put.ToString() };
        public static Delegate Handle => Action;

        public static IResult Action([FromRoute] Guid Id, CategoryRequest categoryRequest, ApplicationDbContext context) 
        {
            var category = context.Categories.Where(c => c.Id == Id).FirstOrDefault();
            category.Name = categoryRequest.Name;
            category.Active = categoryRequest.Active;

            context.SaveChanges();

            return Results.Ok();
        }
    }
}
