using eshop.Entities;

namespace eshop.Application
{
    public interface IProductService
    {
        Product GetProduct(int id);
        IEnumerable<Product> GetProducts();
        IEnumerable<Product> GetProductsByCategoryId(int value);
    }
}
