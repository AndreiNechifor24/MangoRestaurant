using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mango.Services.ProductAPI.Domain.DTOs;
using Mango.Services.ProductAPI.Repository.IRepositories;

namespace Mango.Services.ProductAPI.Controllers
{
    [Route("api/products")]
    public class ProductApiController : ControllerBase
    {
        protected ResponseDto _response;
        private IProductRepository _repo;

        public ProductApiController(IProductRepository repository)
        {
            _repo = repository;
            this._response = new ResponseDto();
        }

        [HttpGet]
        [Route("{productId}")]
        public async Task<object> GetProductById(Guid productId)
        {
            try
            {
                ProductDto productDto = await _repo.GetProductById(productId);
                _response.Result = productDto;
                _response.DisplayMessage = "you have called the id parm. method";
            }
            catch (Exception e)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { e.ToString() };
            }

            return _response;
        }

        [HttpGet]
        [Route("all-products")]
        public async Task<object> GetAllProducts()
        {
            try
            {
                IEnumerable<ProductDto> productDtos = await _repo.GetProducts();
                _response.Result = productDtos;
            }
            catch (Exception e)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { e.ToString() };
            }

            return _response;
        }

        [HttpPost]
        [Route("create")]
        public async Task<object> CreateProduct([FromBody] ProductDto model)
        {
            try
            {
                var resp = await _repo.CreateUpdateProduct(model);
                _response.Result = resp;
            }
            catch (Exception e)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages =
                    new List<string>()
                    {
                        e.ToString()
                    };
            }

            return _response;

        }

        [HttpPost]
        [Route("update")]
        public async Task<object> UpdateProduct([FromBody] ProductDto model)
        {
            try
            {
                var resp = await _repo.CreateUpdateProduct(model);
                _response.Result = resp;
            }
            catch (Exception e)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages =
                    new List<string>()
                    {
                        e.ToString()
                    };
            }

            return _response;

        }

        [HttpDelete]
        [Route("delete/{productId}")]
        public async Task<object> DeleteProduct(Guid productId)
        {

            try
            {
                var resp = await _repo.DeleteProduct(productId);
                _response.Result = resp;
            }
            catch (Exception e)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages =
                    new List<string>()
                    {
                        e.ToString()
                    };
            }

            return _response;

        }
    }
}
