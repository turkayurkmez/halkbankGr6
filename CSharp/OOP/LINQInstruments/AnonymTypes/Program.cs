// See https://aka.ms/new-console-template for more information
using AnonymTypes;

Console.WriteLine("Hello, World!");

var anonim = new { Ad = "Türkay", Soyad = "Ürkmez", Yas = 43 };


var service = new ProductService();
var products = service.GetProducts();
var x = "deneme";
var rnd = new Random();


//Dikkat: object tipinde bir liste tanımladık:
List<object> list = new List<object>();
products.ForEach(p => list.Add(new { UrunAdi = p.Name, Fiyat = p.Price }));

//Dikkat: Liste tanımlamadık, Select kullanarak ANONİM Liste ürettik:
var anonimListe = products.Select(p => new { UrunAdi = p.Name, Fiyat = p.Price });
anonimListe.ToList().ForEach(l => Console.WriteLine(l.UrunAdi));

list.ForEach(ob => Console.WriteLine(ob));



//var kelimesi, kendisine atanan anonim tipi veya değeri bellekte saklar.
