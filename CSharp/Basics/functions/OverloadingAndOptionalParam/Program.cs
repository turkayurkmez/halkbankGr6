// See https://aka.ms/new-console-template for more information
using OverloadingAndOptionalParam;

Console.WriteLine("Hello, World!");

Geometry geometry = new Geometry();
double triangle = geometry.CalculateArea(12, 5, "üçgen");
Console.WriteLine($"Üçgenin alanı: {triangle}");

Console.WriteLine($"Kare: {geometry.AlternativeArea(5)}");
Console.WriteLine($"Daire: {geometry.AlternativeArea(3, symbol: "daire")}");
Console.WriteLine($"Üçgen: {geometry.AlternativeArea(4, unit2: 5, symbol: "üçgen")}");




