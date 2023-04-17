namespace LINQ
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double? Price { get; set; }

        public string Description { get; set; }
        public double Rating { get; set; }
        public int Stock { get; set; }
        public string Renk { get; set; }
        // public var Bilmemne { get; set; }
        public Category Category { get; set; }

    }



    public class ProductService
    {
        private List<Product> products;
        private List<Category> categories;
        public ProductService()
        {
            Category c1 = new() { Id = 1, Name = "Giyim" };
            Category c2 = new() { Id = 1, Name = "Elektronik" };


            categories = new()
            {
               c1,c2
            };

            products = new()
            {
                new (){ Id=1, Name="Gözlük", Price=1000, Rating=4.6, Description="Güneş gözlüğü", Stock=1000, Renk="Siyah", Category=c1},
                new (){ Id=2, Name="Şapka", Price=300, Rating=4.1, Description="Güneş şapkası", Stock=1000, Renk="Kırmızı", Category=c1},
                new (){ Id=3, Name="Tişört", Price=400, Rating=4.3, Description="Yazlık tişört", Stock=1000, Renk="Kırmızı", Category=c1},
                 new (){ Id=4, Name="Laptop", Price=45000, Rating=4.9, Description="Dell", Stock=1000, Renk="Siyah", Category=c2},                new (){Id=5, Name="Telefon", Price=1500, Rating=3.0, Description="Huawei ", Stock=1000, Renk="Kırmızı",Category=c2},
                new (){ Id=6, Name="Klavye", Price=1900, Rating=4.8, Description="Logitech", Stock=1000, Renk="Siyah", Category=c2},
                new (){ Id=7, Name="Kırmızı Tişört", Price=400, Rating=4.9, Description="Yazlık tişört", Stock=1000, Renk="Kırmızı",Category=c1},



            };
        }

        public List<Product> GetProducts()
        {
            return products;
        }
        public List<Category> GetCategories()
        {
            return categories;
        }
    }

}
