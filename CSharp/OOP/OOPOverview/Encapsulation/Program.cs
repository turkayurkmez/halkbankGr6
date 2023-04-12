// See https://aka.ms/new-console-template for more information
using Encapsulation;

Console.WriteLine("Hello, World!");

decimal price = 5;
Product product = new Product();
//if (price<0)
//{
//    Console.WriteLine("Ürün fiyatı negatif olamaz!");
//}
//else
//{
//    product.Price = price;
//}
product.SetPrice(price);
Console.WriteLine($"Ürün Fiyatı: {product.GetPrice()} ");
product.Name = "Gözlük";
Console.WriteLine(product.Name);
product.Rating = 4.6;
product.ChangeStock(120);
Console.WriteLine(product.Stock);
