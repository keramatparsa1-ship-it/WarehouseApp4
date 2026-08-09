using WarehouseApp.Application.DTOs;
using WarehouseApp.Domain.Entities;

namespace WarehouseApp.Application.Common.Interfaces;

public interface IProductRepository
{
    Task<List<Product>> GetAllAsync();

    Task<Product?> GetByIdAsync(int id);

    Task AddAsync(Product product);

    Task UpdateAsync(Product product);

    Task DeleteAsync(Product product);
    Task<ProductDto> AddAsync(AddProductInput input);
}
