using System.Collections;

namespace BuiltInInterfaces
{
    public class ProductItem : IComparable<ProductItem>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public int CompareTo(ProductItem? other)
        {
            if (Price > other?.Price)
            {
                return 1;
            }
            else if (Price < other?.Price)
            {
                return -1;
            }
            return 0;
        }
    }

    public class ProductItemCollection : IEnumerable<ProductItem>
    {
        private List<ProductItem> products = new List<ProductItem>();
        public void Add(ProductItem item)
        {
            products.Add(item);
        }
        public void Clear()
        {
            products.Clear();
        }

        public IEnumerator<ProductItem> GetEnumerator()
        {
            foreach (var item in products)
            {
                yield return item;
            }
        }

        public List<ProductItem> GetSortedProducts()
        {
            products.Sort();
            return products;

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

}
