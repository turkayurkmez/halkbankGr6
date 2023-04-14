// See https://aka.ms/new-console-template for more information
using AnonymTypes;

Console.WriteLine("Hello, World!");

var anonim = new { Ad = "Türkay", Soyad = "Ürkmez", Yas = 43 };

var service = new ProductService();
var products = service.GetProducts();

List<object> list = new List<object>();
products.ForEach(p => list.Add(new { UrunAdi = p.Name, Fiyat = p.Price }));

list.ForEach(ob => Console.WriteLine(ob));
