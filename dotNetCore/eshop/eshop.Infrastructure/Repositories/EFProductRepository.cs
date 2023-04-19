using eshop.Entities;
using eshop.Infrastructure.Data;

namespace eshop.Infrastructure.Repositories
{
    public class EFProductRepository : IProductRepository
    {
        private readonly HalkEshopDbContext dbContext;

        public EFProductRepository(HalkEshopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Add(Product item)
        {
            dbContext.Products.Add(item);
            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var deletingProduct = dbContext.Products.FirstOrDefault(p => p.Id == id);
            dbContext.Products.Remove(deletingProduct);
            dbContext.SaveChanges();

        }

        public Product Get(int id)
        {
            return dbContext.Products.FirstOrDefault(p => p.Id == id);
        }

        public IList<Product> GetAll()
        {
            return dbContext.Products.ToList();
        }

        public IEnumerable<Product> GetProductsByCategoryId(int value)
        {
            return dbContext.Products.Where(p => p.CategoryId == value).ToList();
        }

        public IEnumerable<Product> SearchProductByName(string name)
        {
            return dbContext.Products.Where(p => p.Name.Contains(name));
        }

        public void Update(Product item)
        {
            dbContext.Products.Update(item);
            dbContext.SaveChanges();
        }
    }
}
