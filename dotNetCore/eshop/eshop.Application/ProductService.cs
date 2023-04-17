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

        public IEnumerable<Product> GetProducts()
        {
            return productRepository.GetAll();
        }
    }
}
