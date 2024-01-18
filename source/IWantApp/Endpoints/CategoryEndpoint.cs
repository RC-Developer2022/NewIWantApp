using IWantApp.Domain.Entities;
using IWantApp.Domain.Records.Category;
using IWantApp.Infra.Context;
using Microsoft.AspNetCore.Mvc;

namespace IWantApp.Endpoints;

public static class CategoryEndpoint
{
    public static void MapCategory(WebApplication app) 
    {
        var group = app.MapGroup("/category");

        app.MapPost("", async(CategoryRequest categoryRequest, AppDbContext context) => 
        {
            var category = new Category
            {
                Name = categoryRequest.Name,
            };
            await context.AddAsync(category);
            await context.SaveChangesAsync();
            return Results.Ok("Categoria salva com sucesso!");
        });
    }
}
