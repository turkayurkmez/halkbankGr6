using eshop.Entities;

namespace eshop.Application
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();

    }
}
