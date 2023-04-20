using eshop.Application;
using eshop.Application.DTOs.Requests;
using eshop.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eshop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _productService.GetProducts();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var product = _productService.GetProduct(id);
            if (product == null)
            {
                return NotFound(new { message = "Böyle bir ürün yok" });
            }
            return Ok(product);
        }
        [HttpGet("[action]/{name}")]
        public IActionResult SearchProducts(string name)
        {
            List<Product> products = _productService.SearchProducts(name);
            return Ok(products);
        }

        //REST: Representational State Transfer
        [HttpPost]
        [Authorize]
        public IActionResult CreateProduct(CreateProductRequest request)
        {
            if (ModelState.IsValid)
            {
                int createdProductId = _productService.CreateNewProduct(request);
                return CreatedAtAction(nameof(GetProduct), routeValues: new { id = createdProductId }, null);
            }

            return BadRequest(ModelState);
        }
        [HttpPut("{id}")]
        //idempotent: Bir RESTfull API içerisindeki GET, PUT, PATCH fonksiyonları, yan etki üretmeden aynı sonuç kümesi ile çalışmalıdır.

        public IActionResult UpdateProduct(int id, UpdateProductRequest request)
        {
            bool isExists = _productService.IsProductExists(id);
            if (isExists)
            {
                if (ModelState.IsValid)
                {
                    _productService.UpdateExistingProduct(request);
                    return Ok();
                }
                return BadRequest(ModelState);


            }
            return NotFound();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            bool isExists = _productService.IsProductExists(id);
            if (isExists)
            {
                _productService.Delete(id);
                return Ok();
            }
            return NotFound();
        }



    }
}
