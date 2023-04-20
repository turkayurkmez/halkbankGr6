using eshop.Entities;

namespace eshop.Infrastructure.Repositories
{
    public class FakeProductRepository : IProductRepository
    {
        private List<Product> products;
        public FakeProductRepository()
        {
            products = new List<Product> {
          new Product { Id = 1, Name = "Ürün 1", Price = 1, Description = "Ürün 1 Açıklama", DiscountRate = 0.15, Rating = 4.2, ImageUrl = "https://cdn.dsmcdn.com/ty545/product/media/images/20220930/13/181804901/583691889/1/1_org.jpg", CategoryId=1 },

         new Product { Id =2, Name = "Ürün 2", Price = 1, Description = "Ürün 2 Açıklama", DiscountRate = 0.15, Rating = 4.2, ImageUrl = "https://cdn.dsmcdn.com/ty545/product/media/images/20220930/13/181804901/583691889/1/1_org.jpg", CategoryId=2 },
         new Product { Id = 3, Name = "Ürün 3", Price = 1, Description = "Ürün 3 Açıklama", DiscountRate = 0.15, Rating = 4.2, ImageUrl = "https://cdn.dsmcdn.com/ty545/product/media/images/20220930/13/181804901/583691889/1/1_org.jpg", CategoryId=3 }

            };
        }
        public void Add(Product item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public IList<Product> GetAll()
        {
            return products;
        }

        public IEnumerable<Product> GetProductsByCategoryId(int value)
        {
            return products.Where(p => p.CategoryId == value).ToList();
        }

        public bool ItExists(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> SearchProductByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(Product item)
        {
            throw new NotImplementedException();
        }
    }
}
