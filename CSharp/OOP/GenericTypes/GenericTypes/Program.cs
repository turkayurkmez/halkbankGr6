// See https://aka.ms/new-console-template for more information
using GenericTypes;
using System.Collections;

Show("Halkbank");
Show(2023);
Show(new Random());


ArrayList arrayList = new ArrayList();
arrayList.Add(13);
arrayList.Add('A');

Point point = new Point();
GeneralPoint generalPoint = new GeneralPoint();
generalPoint.X = "asdsads";

GenericPoint<decimal> genericPoint = new GenericPoint<decimal>();
genericPoint.X = point.X;
genericPoint.Y = point.Y;
genericPoint.Reset();
Console.WriteLine(genericPoint.IsEqual());

GenericPoint<byte> genericPoint1 = new GenericPoint<byte>();

int a = 80;
int b = 90;
Console.WriteLine($"a: {a}");
Console.WriteLine($"b: {b}");
Console.WriteLine("------------ Swap -------------------");
Swap<int>(ref a, ref b);
Console.WriteLine($"a: {a}");
Console.WriteLine($"b: {b}");

string w1 = "Tükiye";
string w2 = "Hollanda";
Console.WriteLine($"ülke1: {w1}");
Console.WriteLine($"ülke2: {w2}");
Swap(ref w1, ref w2);
Console.WriteLine($"ülke1: {w1}");
Console.WriteLine($"ülke2: {w2}");

Console.WriteLine("Hello, World!");

//Boxing: Kutunun içine yerleştirmek, kutulamak
object nesne = 5;
object olurMu = false;
nesne = "1.65";
//UnBoxing: Kutu içinden çıkarmak:
string kelime = (string)nesne;
Console.WriteLine(kelime);

//int number = (int)GetItem("hadi bakalım!");

void Show(object value)
{
    Console.WriteLine(value);
}

object GetItem(object value)
{
    return value;
}


void Swap<T>(ref T left, ref T right)
{
    T temp;
    temp = left;
    left = right;
    right = temp;

}

