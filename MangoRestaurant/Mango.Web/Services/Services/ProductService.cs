using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Mango.Web.Domain;
using Mango.Web.Domain.DTOs;
using Mango.Web.Services.IServices;

namespace Mango.Web.Services.Services
{
    public class ProductService : BaseService, IProductService
    {
        public ProductService(IHttpClientFactory httpClient) : base(httpClient)
        {
        }

        public async Task<T> GetAllProductsAsync<T>()
        {
            return await this.SendAsync<T>(new APIRequest()
            {
                CallType = StaticDetails.CallType.GET,
                Url = StaticDetails.ProductAPIBase + $"/api/products/all-products",
                AccessToken = ""
            });
        }

        public async Task<T> GetAllProductByIdAsync<T>(Guid id)
        {
            return await this.SendAsync<T>(new APIRequest()
            {
                CallType = StaticDetails.CallType.GET,
                Url = StaticDetails.ProductAPIBase + $"/api/products/" + id,
                AccessToken = ""
            });
        }

        public async Task<T> CreateProductAsync<T>(ProductDto model)
        {
            return await this.SendAsync<T>(new APIRequest()
            {
                CallType = StaticDetails.CallType.POST,
                Data = model,
                Url = StaticDetails.ProductAPIBase + "/api/products/create",
                AccessToken = ""
            });
        }

        public async Task<T> UpdateProductAsync<T>(ProductDto model)
        {
            return await this.SendAsync<T>(new APIRequest()
            {
                CallType = StaticDetails.CallType.POST,
                Data = model
                Url = StaticDetails.ProductAPIBase + $"/api/products/update",
                AccessToken = ""
            });
        }

        public async Task<T> DeleteProductAsync<T>(Guid id)
        {
            return await this.SendAsync<T>(new APIRequest()
            {
                CallType = StaticDetails.CallType.DELETE,
                Url = StaticDetails.ProductAPIBase + $"/api/products/delete/" + id,
                AccessToken = ""
            });
        }
    }
}
