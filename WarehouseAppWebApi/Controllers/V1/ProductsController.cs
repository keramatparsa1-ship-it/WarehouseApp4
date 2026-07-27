using Microsoft.AspNetCore.Mvc;
using WarehouseApp.Application.DTOs;
using WarehouseApp.Domain.Entities;
using Asp.Versioning;
using WarehouseApp.Application.Common.Interfaces;

namespace WarehouseApp.WebApi.Controllers.V1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _productRepository.GetAllAsync();

            var productDtos = products.Select(p => new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                CategoryId = p.CategoryId,
                CategoryName = p.Category?.Name ?? "",
                Price = p.Price
            });

            return Ok(productDtos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var p = await _productRepository.GetByIdAsync(id);

            if (p == null)
                return NotFound();

            var dto = new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                CategoryId = p.CategoryId,
                CategoryName = p.Category?.Name ?? "",
                Price = p.Price
            };

            return Ok(dto);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductDto dto)
        {
            
            var product = new Product(dto.Name, dto.CategoryId, dto.Price);

            await _productRepository.AddAsync(product);

            var resultDto = new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                CategoryId = product.CategoryId,
                Price = product.Price
            };

            return CreatedAtAction(nameof(GetById), new { id = product.Id }, resultDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, ProductDto dto)
        {
            var existing = await _productRepository.GetByIdAsync(id);

            if (existing == null)
                return NotFound();

           
            existing.Update(dto.Name, dto.CategoryId, dto.Price);

            await _productRepository.UpdateAsync(existing);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var existing = await _productRepository.GetByIdAsync(id);

            if (existing == null)
                return NotFound();

            await _productRepository.DeleteAsync(existing);

            return NoContent();
        }
    }
}
