using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseApp.Application.DTOs
{
    public class AddProductInput
    {
        public string Name { get; set; } = string.Empty;
        public string? Sku { get; set; }
        public decimal Price { get; set; }
        public int InitialStock { get; set; }
        public string? Description { get; set; }
    }
}
