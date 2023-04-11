// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bir şekil girin (Üçgen, Dikdörtgen, Kare)");
string geometry = Console.ReadLine();

if (geometry == "Üçgen")
{
    Console.WriteLine($"Formülü: (a x h) / 2");

}
else if (geometry == "Kare")
{

    Console.WriteLine("Formülü: a x a");
}
else if (geometry == "Dikdörtgen")
{
    Console.WriteLine("a x b");
}
else
{
    Console.WriteLine("Belirtilen şekillerden birini seçin!");
}


switch (geometry)
{
    case "Üçgen":
        Console.WriteLine($"Formülü: (a x h) / 2");
        break;
    case "Kare":
        Console.WriteLine("Formülü: a x a");
        break;
    case "Dikdörtgen":
        Console.WriteLine("a x b");
        break;
    default:
        break;
}