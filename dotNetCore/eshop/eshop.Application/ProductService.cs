using eshop.Application.DTOs.Requests;
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

        public int CreateNewProduct(CreateProductRequest productRequest)
        {
            var product = new Product
            {
                CategoryId = productRequest.CategoryId,
                CreatedDate = DateTime.Now,
                Description = productRequest.Description,
                DiscountRate = productRequest.DiscountRate,
                ImageUrl = productRequest.ImageUrl,
                Name = productRequest.Name,
                Price = productRequest.Price,
                Rating = productRequest.Rating

            };

            productRepository.Add(product);
            return product.Id;
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

        public List<Product> SearchProducts(string name)
        {
            return productRepository.SearchProductByName(name).ToList();
        }

        public void UpdateExistingProduct(Product product)
        {
            productRepository.Update(product);
        }
    }
}
