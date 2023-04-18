using eshop.Application;
using Microsoft.AspNetCore.Mvc;

namespace eshop.MVC.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        private ICategoryService categoryService;

        public MenuViewComponent(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var categories = categoryService.GetCategories();
            return View(categories);
        }
    }
}
