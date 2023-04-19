using eshop.Entities;

namespace eshop.Application
{
    public interface IProductService
    {
        void CreateNewProduct(Product newProduct);
        Product GetProduct(int id);
        IEnumerable<Product> GetProducts();
        IEnumerable<Product> GetProductsByCategoryId(int value);
        void UpdateExistingProduct(Product product);
    }
}
