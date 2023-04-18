using eshop.Entities;
using eshop.Infrastructure.Repositories;

namespace eshop.Application
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository ?? throw new ArgumentNullException(nameof(categoryRepository));
        }

        public IEnumerable<Category> GetCategories()
        {
            return categoryRepository.GetAll();
        }
    }
}
