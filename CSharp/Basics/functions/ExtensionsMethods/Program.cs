// See https://aka.ms/new-console-template for more information
using ExtensionsMethods;

Console.WriteLine("Hello, World!");
int number = 8;
int square = number.GetSquare();
Console.WriteLine(square);

List<string> words = new List<string>() { "hücre", "biyoloji", "golgi aygıtı" };

Random random = new Random();
Console.WriteLine($"char: {random.NextChar()}");
Console.WriteLine($"string: {random.NextString(6)}");
Console.WriteLine($"string: {random.NextString(words)}");

