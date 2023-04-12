// See https://aka.ms/new-console-template for more information
using BuiltInInterfaces;

Console.WriteLine("Hello, World!");

ProductItem item1 = new ProductItem() { Id = 1, Name = "A", Price = 246, Stock = 100 };
ProductItem item2 = new ProductItem() { Id = 2, Name = "B", Price = 52, Stock = 300 };
ProductItem item3 = new ProductItem() { Id = 3, Name = "C", Price = 1000, Stock = 10 };

ProductItemCollection productItemCollection = new ProductItemCollection();
productItemCollection.Add(item1);
productItemCollection.Add(item2);
productItemCollection.Add(item3);

productItemCollection.GetSortedProducts();
foreach (var item in productItemCollection)
{
    Console.WriteLine($"{item.Name} {item.Price}");
}

