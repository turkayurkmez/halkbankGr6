using eshop.Entities;

namespace eshop.Infrastructure.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetProductsByCategoryId(int value);
        IEnumerable<Product> SearchProductByName(string name);
    }
}
