using WarehouseApp.Shared.Core.Domain.Common;

namespace WarehouseApp.Domain.Entities;

public class InventoryItem : AggregateRoot
{
    private InventoryItem()
    {
    }

    public InventoryItem(int productId, int warehouseId, int quantity)
    {
        if (quantity < 0)
            throw new ArgumentException("Quantity cannot be negative.");

        ProductId = productId;
        WarehouseId = warehouseId;
        Quantity = quantity;
        CreatedAt = DateTime.UtcNow;
    }

    public int ProductId { get; private set; }

    public Product? Product { get; private set; }

    public int WarehouseId { get; private set; }

    public Warehouse? Warehouse { get; private set; }

    public int Quantity { get; private set; }

    public void Increase(int quantity)
    {
        if (quantity <= 0)
            throw new ArgumentException("Quantity must be greater than zero.");

        Quantity += quantity;
        SetUpdatedAt();
    }

    public void Decrease(int quantity)
    {
        if (quantity <= 0)
            throw new ArgumentException("Quantity must be greater than zero.");

        if (Quantity < quantity)
            throw new InvalidOperationException("Not enough stock.");

        Quantity -= quantity;
        SetUpdatedAt();
    }
}
