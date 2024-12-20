﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mango.Web.Models.DTOs;

namespace Mango.Web.Services.IServices
{
    public interface IProductService : IBaseService 
    {
        Task<T> GetAllProductsAsync<T>();
        
        Task<T> GetAllProductByIdAsync<T>(Guid id);

        Task<T> CreateProductAsync<T>(ProductDto model);
        
        Task<T> UpdateProductAsync<T>(ProductDto model);
        
        Task<T> DeleteProductAsync<T>(Guid id);
    }
}
