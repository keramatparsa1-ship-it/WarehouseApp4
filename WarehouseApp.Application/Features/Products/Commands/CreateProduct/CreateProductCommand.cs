using MediatR;

namespace WarehouseApp.Application.Features.Products.Commands.CreateProduct;


public record CreateProductCommand : IRequest<Guid>
{
    public string Name { get; init; } = string.Empty;
    public decimal Price { get; init; }
    public string Description { get; init; } = string.Empty;
}
