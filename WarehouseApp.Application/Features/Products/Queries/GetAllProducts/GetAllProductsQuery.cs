using MediatR;
using WarehouseApp.Application.DTOs;

namespace WarehouseApp.Application.Features.Products.Queries.GetAllProducts;

public class GetAllProductsQuery : IRequest<List<ProductDto>>
    {
    }
