// See https://aka.ms/new-console-template for more information
using usingDelegates;

Console.WriteLine("Hello, World!");
List<int> numbers = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
FilterHelper filterHelper = new FilterHelper();
//.Net 1.0 : 2001
List<int> evenNumbers = filterHelper.Filter(numbers, AllFilters.isEven);
//.Net 2.0:
List<int> oddNumbers = filterHelper.Filter(numbers,
delegate (int n)
{
    return n % 2 == 1;
});

Console.WriteLine("Kaçtan büyük olsun?");
int minNumber = int.Parse(Console.ReadLine());
//.NET 3.5:
List<int> bigThenSix = filterHelper.Filter(numbers, np => np > minNumber);
List<int> justEven = filterHelper.Filter(numbers, x => x % 2 == 0);
List<int> primeNumbers = filterHelper.Filter(numbers, x =>
{
    return x < 4;
});

alternateShow(bigThenSix);

void show(List<int> numbers)
{
    foreach (int number in numbers)
    {
        Console.WriteLine(number);
    }
}
void alternateShow(List<int> numbers)
{
    numbers.ForEach(p => Console.WriteLine(p));
}



