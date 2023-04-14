namespace AnonymTypes
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public string Description { get; set; }
        public double Rating { get; set; }
        public int Stock { get; set; }


    }

    public class ProductService
    {
        private List<Product> products;
        public ProductService()
        {
            products = new()
            {
                new (){ Name="Gözlük", Price=1000, Rating=4.6, Description="Güneş gözlüğü", Stock=1000},
                new (){ Name="Şapka", Price=300, Rating=4.1, Description="Güneş şapkası", Stock=1000},
                new (){ Name="Tişört", Price=400, Rating=4.3, Description="Yazlık tişört", Stock=1000},

            };
        }

        public List<Product> GetProducts()
        {
            return products;
        }
    }

}
