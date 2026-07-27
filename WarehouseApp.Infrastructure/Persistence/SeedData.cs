using WarehouseApp.Domain.Entities;

namespace WarehouseApp.Infrastructure.Persistence;

public static class SeedData
{
    public static void Seed(AppDbContext context)
    {
        //context.Database.EnsureCreated();

        if (!context.Categories.Any())
        {
            context.Categories.AddRange(
                new Category
                {
                    Id = 1,
                    Name = "Electronics",
                    Description = "Electronic products"
                },
                new Category
                {
                    Id = 2,
                    Name = "Food",
                    Description = "Food and grocery products"
                },
                new Category
                {
                    Id = 3,
                    Name = "Clothing",
                    Description = "Clothing and apparel products"
                }
            );
        }

        if (!context.Warehouses.Any())
        {
            context.Warehouses.AddRange(
                new Warehouse
                {
                    Id = 1,
                    Name = "Main Warehouse",
                    Location = "Tehran"
                },
                new Warehouse
                {
                    Id = 2,
                    Name = "Backup Warehouse",
                    Location = "Karaj"
                }
            );
        }

        context.SaveChanges();
    }
}
