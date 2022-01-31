using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mango.Web.Models.DTOs;
using Mango.Web.Services.IServices;
using Newtonsoft.Json;

namespace Mango.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<ProductDto> products = new();

            var response = await _productService.GetAllProductsAsync<ResponseDto>();

            if (response != null && response.IsSuccess)
            {
                products = JsonConvert.DeserializeObject<List<ProductDto>>(Convert.ToString(response.Result));
            }

            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductDto model)
        {
            var resp = await _productService.CreateProductAsync<ResponseDto>(model);

            if (resp.IsSuccess)
            {
                return RedirectToAction("Index");
            }

            else
            {
                ModelState.AddModelError(key: "CreateModelError", 
                    "Something went wrong");

                return View(model);
            }
            
        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid productId)
        {
            var resp = await _productService.GetAllProductByIdAsync<ResponseDto>(productId);
            if (resp != null && resp.IsSuccess)
            {
                var product = JsonConvert.DeserializeObject<ProductDto>(Convert.ToString(resp.Result));
                return View(product); 
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Update(ProductDto model)
        {
            var resp = await _productService.UpdateProductAsync<ResponseDto>(model);        

            if (resp.IsSuccess)
            {
                return RedirectToAction("Index");
            }

            else
            {
                ModelState.AddModelError(key: "UpdateModelError",
                    "Something went wrong");

                return View(model);
            }

        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid productId)
        {
            var resp = await _productService.GetAllProductByIdAsync<ResponseDto>(productId);
            if (resp != null && resp.IsSuccess)
            {
                var product = JsonConvert.DeserializeObject<ProductDto>(Convert.ToString(resp.Result));
                return View(product);
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(ProductDto model)
        {
            var resp = await _productService.DeleteProductAsync<ResponseDto>(model.ProductId);

            if (resp.IsSuccess)
            {
                return RedirectToAction("Index");
            }

            else
            {
                ModelState.AddModelError(key: "UpdateModelError",
                    "Something went wrong");

                return View(model);
            }

        }
    }
}
