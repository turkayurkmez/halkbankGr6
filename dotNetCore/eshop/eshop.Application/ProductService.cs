using eshop.Entities;
using eshop.Infrastructure.Repositories;

namespace eshop.Application
{
    public class ProductService : IProductService
    {



        private IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public void CreateNewProduct(Product newProduct)
        {
            productRepository.Add(newProduct);
        }

        public Product GetProduct(int id)
        {
            return productRepository.Get(id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return productRepository.GetAll();
        }

        public IEnumerable<Product> GetProductsByCategoryId(int value)
        {
            return productRepository.GetProductsByCategoryId(value);

        }

        public void UpdateExistingProduct(Product product)
        {
            productRepository.Update(product);
        }
    }
}
