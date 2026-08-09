using WarehouseApp.Application.Common.Interfaces;
using WarehouseApp.Application.DTOs;

namespace WarehouseApp.WebApi.GraphQL
{
    public class ProductMutation
    {
        private readonly IProductRepository _repository;

        public ProductMutation(IProductRepository repository)
            => _repository = repository;

        public async Task<ProductDto> AddProduct(AddProductInput input)
            => await _repository.AddAsync(input);
    }
}
