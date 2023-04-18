using eshop.Entities;

namespace eshop.MVC.Models
{

    public class ProductItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
    public class ProductItemCollection
    {
        public List<ProductItem> Products { get; set; } = new List<ProductItem>();

        public void Clear() => Products.Clear();
        public double? GetTotalPrice() => Products.Sum(x => x.Quantity * (x.Product.Price * (1 - x.Product.DiscountRate)));
        public void RemoveFromCart(int id) => Products.RemoveAll(p => p.Product.Id == id);

        public void AddProduct(ProductItem productItem)
        {
            var existingProduct = Products.FirstOrDefault(p => p.Product.Id == productItem.Product.Id);
            if (existingProduct == null)
            {
                Products.Add(productItem);
            }
            else
            {
                existingProduct.Quantity += productItem.Quantity;
            }
        }

    }
}
