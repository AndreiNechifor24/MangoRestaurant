using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mango.Services.ProductAPI.Domain.DTOs;
using Mango.Services.ProductAPI.Domain.Models;

namespace Mango.Services.ProductAPI.Repository.IRepositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> GetProducts();
        Task<ProductDto> GetProductById(Guid id);
        Task<ProductDto> CreateUpdateProduct(ProductDto model);
        Task<bool> DeleteProduct(Guid productId);
    }
}
