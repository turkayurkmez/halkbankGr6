using eshop.Application;
using eshop.Entities;
using eshop.MVC.Extensions;
using eshop.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace eshop.MVC.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IProductService productService;

        public ShoppingCartController(IProductService productService)
        {
            this.productService = productService;
        }

        public IActionResult Index()
        {
            var collection = GetCollectionFromSession();
            return View(collection);
        }

        public IActionResult AddToCart(int id)
        {
            Product product = productService.GetProduct(id);
            string message = string.Empty;
            if (product != null)
            {
                ProductItem productItem = new ProductItem { Product = product, Quantity = 1 };
                ProductItemCollection shoppingCart = GetCollectionFromSession();
                shoppingCart.AddProduct(productItem);
                SaveCollectionToSession(shoppingCart);

                message = $"{product.Name} ürünü sepete eklendi ";
                return Json(new { message = message, from = "Sunucu..." });
            }
            message = "Belirttiğiniz id'li değer bulunamadı";
            return NotFound(new { message = message });

        }

        private void SaveCollectionToSession(ProductItemCollection shoppingCart)
        {
            HttpContext.Session.SetJson("basket", shoppingCart);
        }

        private ProductItemCollection GetCollectionFromSession()
        {
            //eğer ilk kez sepete ürün eklenecekse yeni koleksiyon ve Session oluşturulmalı.
            //daha önce eklenmiş ise; session içinde var olan koleksiyon kullanılmalı.
            //string deserialized = HttpContext.Session.GetString("basket");
            //if (deserialized == null)
            //{
            //    return new ProductItemCollection();
            //}
            //else
            //{
            //    return JsonSerializer.Deserialize<ProductItemCollection>(deserialized);
            //}

            var collection = HttpContext.Session.GetJson<ProductItemCollection>("basket");
            return collection ?? new ProductItemCollection();
        }
    }
}
