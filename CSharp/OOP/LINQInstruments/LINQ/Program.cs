// See https://aka.ms/new-console-template for more information
using LINQ;

Console.WriteLine("Hello, World!");
//LINQ: Language INtegrated Query
//Select Name, Price FROM Products WHERE Price<1000 
//                          Order by Price
var service = new ProductService();
var products = service.GetProducts();

var result = from product in products
             where product?.Price < 1000
             orderby product.Price
             select new { UrunAdi = product.Name, Fiyat = product.Price };


//foreach (var product in products)
//{
//    if (product.Price<1000)
//    {

//    }
//}


result.ToList().ForEach(r => Console.WriteLine($"{r.UrunAdi} --> {r.Fiyat}"));
Console.WriteLine("-------------------------------------------");

var extensionResult = products.Where(p => p != null && p.Description.Contains("Dell"))
                              .OrderBy(p => p.Price)
                              .Select(p => new { p.Name, p.Price })
                              .ToList();

extensionResult.ForEach(e => Console.WriteLine(e.Name + "--> " + e.Price));

var findingProduct = products.FirstOrDefault(p => p.Id == 3);
Console.WriteLine("-------------------------------");
Console.WriteLine($"Bulunan ürün: {findingProduct.Name}");

//var throwingException = products.SingleOrDefault(x => x.Id == 3);

var orderedProducts = products.OrderByDescending(p => p.Price)
                              .ThenByDescending(p => p.Rating)
                              .ThenBy(p => p.Name)
                              .ToList();

orderedProducts.ForEach(op => Console.WriteLine($"{op.Name}....{op.Price}.... {op.Rating}"));

//Aggregate Func:
var averageRating = products.Average(p => p.Rating);
Console.WriteLine("Ortalama değer:" + Math.Round(averageRating, 2));
var count = products.Count(p => p.Rating < 4.0);

Console.WriteLine("Rating'i 4'ün altında olan ürün sayısı:" + count);

//Max, Min, Sum, 
var group = products.GroupBy(p => p.Renk,
                             pr => new { pr.Name, pr.Price, pr.Rating },
                             (renk, products) => new
                             {
                                 Key = renk,
                                 Count = products.Count(),
                                 MinPrice = products.Min(p => p.Price),
                                 Max = products.FirstOrDefault(p => p.Price == products.Max(x => x.Price))?.Name + "( " + products.Max(x => x.Price) + ")",
                                 AvgRating = Math.Round(products.Average(p => p.Rating), 2)
                             })
                     .ToList();

group.ForEach(op => Console.WriteLine($"{op.Key}\t\t{op.Count}\t\t{op.MinPrice}\t\t{op.Max}\t\t{op.AvgRating}\t\t"));

Console.WriteLine("--------------------------------------");

//Eagle: İlişki property üzerinden sağlanır.
var joinedResult = products.Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name }).ToList();

joinedResult.ForEach(op => Console.WriteLine($"{op.Name}\t\t{op.Price}\t\t{op.CategoryName}"));


var categories = service.GetCategories();
//Join: ilişki doğrudan değer eşitliği üzerinden sağlanır:
var join = categories.Join(products,
                         category => category,
                         product => product.Category,
                         (category, product) => new { UrunAdi = product.Name, Kategorisi = category.Name })
                      .ToList();

Console.WriteLine("--------------------------------------");

join.ForEach(op => Console.WriteLine($"{op.UrunAdi}\t\t{op.Kategorisi}"));




