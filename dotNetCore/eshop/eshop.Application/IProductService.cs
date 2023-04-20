using eshop.Application.DTOs.Requests;
using eshop.Entities;

namespace eshop.Application
{
    public interface IProductService
    {
        void CreateNewProduct(Product newProduct);
        int CreateNewProduct(CreateProductRequest productRequest);
        void Delete(int id);
        Product GetProduct(int id);
        IEnumerable<Product> GetProducts();
        IEnumerable<Product> GetProductsByCategoryId(int value);
        List<Product> SearchProducts(string name);
        void UpdateExistingProduct(Product product);
        void UpdateExistingProduct(UpdateProductRequest updateProductRequest);

        bool IsProductExists(int id);
    }
}
