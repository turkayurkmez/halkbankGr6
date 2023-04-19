using eshop.Application;
using eshop.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace eshop.MVC.Controllers
{
    [Authorize(Roles = "Admin,Editor")]

    public class ProductsController : Controller
    {

        private readonly IProductService productService;
        private readonly ICategoryService categoryService;

        public ProductsController(IProductService productService, ICategoryService categoryService)
        {
            this.productService = productService;
            this.categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var products = productService.GetProducts();
            return View(products);
        }

        public IActionResult Create()
        {
            ViewBag.Categories = getCategoriesForSelect();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product newProduct)
        {
            if (ModelState.IsValid)
            {
                productService.CreateNewProduct(newProduct);
                return RedirectToAction("Index");
            }
            ViewBag.Categories = getCategoriesForSelect();
            return View();

        }


        public IActionResult Edit(int id)
        {
            var product = productService.GetProduct(id);
            if (product != null)
            {
                ViewBag.Categories = getCategoriesForSelect();

                return View(product);
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                productService.UpdateExistingProduct(product);
                return RedirectToAction("Index");
            }

            ViewBag.Categories = getCategoriesForSelect();
            return View();
        }

        private IEnumerable<SelectListItem> getCategoriesForSelect()
        {
            return categoryService.GetCategories()
                                  .Select(category =>
                                  new SelectListItem { Text = category.Name, Value = category.Id.ToString() }
                                  );

        }
    }
}
