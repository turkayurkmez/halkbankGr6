using eshop.Application.DTOs.Requests;
using eshop.Entities;

namespace eshop.Application
{
    public interface IProductService
    {
        void CreateNewProduct(Product newProduct);
        int CreateNewProduct(CreateProductRequest productRequest);
        Product GetProduct(int id);
        IEnumerable<Product> GetProducts();
        IEnumerable<Product> GetProductsByCategoryId(int value);
        List<Product> SearchProducts(string name);
        void UpdateExistingProduct(Product product);
    }
}
