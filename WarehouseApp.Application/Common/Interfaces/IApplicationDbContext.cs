using Microsoft.EntityFrameworkCore;
using WarehouseApp.Domain.Entities;

namespace WarehouseApp.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    
    DbSet<Product> Products { get; }

    
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}