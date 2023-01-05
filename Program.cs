using Aplicativo_de_Pedido.Endpoints.Categories;
using Aplicativo_de_Pedido.infra.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddSqlServer<ApplicationDbContext>(builder.Configuration["ConnectionString:AppPedido"]);

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();


        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.MapMethods(CategoryPost.Tamplate, CategoryPost.Methods, CategoryPost.Handle);

        app.Run();
    }
}