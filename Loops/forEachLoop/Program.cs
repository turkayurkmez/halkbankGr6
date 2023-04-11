// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<string> products = new List<string>();

string[] words = { "Mikrofon", "Klavye", "Mouse", "Kamera" };

products = new List<string>() { "Mikrofon", "Klavye", "Mouse", "Kamera" };
products.Add("Kulaklık");

foreach (string product in products)
{
    Console.WriteLine(product);

}
