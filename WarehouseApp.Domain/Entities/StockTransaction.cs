using WarehouseApp.Domain.Enums;

namespace WarehouseApp.Domain.Entities;

public class StockTransaction
{
    private StockTransaction()
    {
    }

    public StockTransaction(
        int productId,
        int warehouseId,
        int quantity,
        StockTransactionType transactionType)
    {
        if (productId <= 0)
            throw new ArgumentException("ProductId is required.");

        if (warehouseId <= 0)
            throw new ArgumentException("WarehouseId is required.");

        if (quantity <= 0)
            throw new ArgumentException("Quantity must be greater than zero.");

        ProductId = productId;
        WarehouseId = warehouseId;
        Quantity = quantity;
        TransactionType = transactionType;
        TransactionDate = DateTime.UtcNow;
    }

    public int Id { get; private set; }

    public int ProductId { get; private set; }

    public int WarehouseId { get; private set; }

    public int Quantity { get; private set; }

    public StockTransactionType TransactionType { get; private set; }

    public DateTime TransactionDate { get; private set; } = DateTime.UtcNow;
}
