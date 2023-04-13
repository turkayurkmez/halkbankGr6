// See https://aka.ms/new-console-template for more information
using LSP;

Console.WriteLine("Hello, World!");

//
Geometry geometry = new Geometry();
var rect = geometry.GetAreaCalcutable(5, 6);

Console.WriteLine(rect.GetArea());