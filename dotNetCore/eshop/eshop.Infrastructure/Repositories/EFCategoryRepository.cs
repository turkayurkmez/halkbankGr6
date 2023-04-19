using eshop.Entities;
using eshop.Infrastructure.Data;

namespace eshop.Infrastructure.Repositories
{
    public class EFCategoryRepository : ICategoryRepository
    {
        private readonly HalkEshopDbContext dbContext;

        public EFCategoryRepository(HalkEshopDbContext dbContext)
        {
            this.dbContext = dbContext;
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
            return dbContext.Categories.ToList();
        }

        public void Update(Category item)
        {
            throw new NotImplementedException();
        }
    }
}
