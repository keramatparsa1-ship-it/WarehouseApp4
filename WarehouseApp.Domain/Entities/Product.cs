using WarehouseApp.Shared.Core.Domain.Common;

namespace WarehouseApp.Domain.Entities;

public class Product : AggregateRoot
{
    private Product()
    {
    
    }

    public Product(string name, int categoryId, decimal price)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Product name is required.");

        if (price < 0)
            throw new ArgumentException("Price cannot be negative.");

        Name = name;
        CategoryId = categoryId;
        Price = price;
        CreatedAt = DateTime.UtcNow;
    }

    public string Name { get; private set; } = string.Empty;

    public int CategoryId { get; private set; }

    public decimal Price { get; private set; }

    
    public Category? Category { get; private set; }

    public void Update(string name, int categoryId, decimal price)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Product name is required.");

        if (price < 0)
            throw new ArgumentException("Price cannot be negative.");

        Name = name;
        CategoryId = categoryId;
        Price = price;
        SetUpdatedAt();
    }
}
