// See https://aka.ms/new-console-template for more information
using ObjectVSClass;

Console.WriteLine("Hello, World!");

Product umbrella = new Product();
umbrella.Name = "Winter";

Product anotherUmbrella = umbrella;
anotherUmbrella.Name = "Summer";

Console.WriteLine(umbrella.Name);


StProduct umb = new StProduct();
umb.Name = "Winter";
StProduct anotherUmb = umb;
anotherUmb.Name = "Summer";
Console.WriteLine($"Struct kullandığımda: {umb.GetType().Name}:{umb.Name}\n{anotherUmb.GetType().Name}:{anotherUmb.Name}");

Random rnd = new Random();

Product? hat = new Product();
hat.Name = "Cowboy's hat";
hat = null;
//if (hat == null)
//{
//    hat = new Product();

//}
//var hatType = hat ?? new Product();
//hatType.Name = "Cowboy's hat";
Console.WriteLine(hat?.Name);

bool? isClosed = null;
List<string> cities = null;
(cities ??= new List<string>()).Add("Çanakkale");
Console.WriteLine(string.Join(" ", cities));
Console.WriteLine(isClosed ?? false);

Product product = null;
//if (product == null)
//{
//    throw new ArgumentNullException();
//}
Product p2 = product ?? throw new NullReferenceException();


//if (product == null)
//{
//    product = new Product();
//    product.Name = "XYZ";
//}

product ??= new Product() { Name = "XYZ" };
Console.WriteLine(product.Name);

Console.WriteLine((product ?? new Product { Name = "DEF" }).Name);

int? sayi = null;
Console.WriteLine(sayi ?? 0);
