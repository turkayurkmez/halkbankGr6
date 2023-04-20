using eshop.Entities;

namespace eshop.Infrastructure.Repositories
{
    public class FakeCategoryRepository : ICategoryRepository
    {
        private List<Category> _categories;
        public FakeCategoryRepository()
        {
            _categories = new List<Category>()
            {
                new Category { Id = 1, Name="Giyim"},
                new Category { Id = 2, Name="Teknoloji"},
                new Category { Id = 3, Name="Kırtasiye"}
            };
        }
        public void Add(Category item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Category Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Category> GetAll()
        {
            return _categories;
        }

        public bool ItExists(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Category item)
        {
            throw new NotImplementedException();
        }
    }
}
