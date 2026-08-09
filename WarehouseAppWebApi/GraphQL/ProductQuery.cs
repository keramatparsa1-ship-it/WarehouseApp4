using WarehouseApp.Application.Common.Interfaces;
using WarehouseApp.Application.DTOs;

namespace WarehouseApp.WebApi.GraphQL
{
    public class ProductQuery
    {
        private readonly IProductRepository _repository;

        public ProductQuery(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<IReadOnlyList<ProductDto>> GetProductsAsync()
            => (IReadOnlyList<ProductDto>)await _repository.GetAllAsync();
    }
}
