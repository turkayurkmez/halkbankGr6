// See https://aka.ms/new-console-template for more information
List<int> weathers = new List<int> { 15, -3, 5, 12 };
int minWeather = findMinimumNumbersIn(weathers);
Console.WriteLine("Hello, World!");
//Sayı bulmaca:
/*
 * 1. Bir sayı üret!
 * 2. Bu sayının tahmin edilmesini iste!
 * 3. Sayıları karşılaştır ve yönlendir!
 * 4. Bilirse bitir!
 */
int randomNumber = getRandomNumber(1, 100);
CompareResult navigate;
do
{
    int suggest = getSuggestFromPlayer();
    navigate = compare(randomNumber, suggest);
    showNavigateToPlayer(navigate);
} while (navigate != CompareResult.Equal);






void showNavigateToPlayer(CompareResult navigate)
{
    switch (navigate)
    {
        case CompareResult.Equal:
            Console.WriteLine("Bildiniz");
            break;
        case CompareResult.Big:
            Console.WriteLine("Yukarı");
            break;
        case CompareResult.Small:
            Console.WriteLine("Aşağı");
            break;
        default:
            break;
    }
}

CompareResult compare(int randomNumber, int suggest)
{
    CompareResult outputResponse;
    if (randomNumber > suggest)
    {
        outputResponse = CompareResult.Big;
    }
    else if (randomNumber < suggest)
    {
        outputResponse = CompareResult.Small;
    }
    else
    {
        outputResponse = CompareResult.Equal;
    }

    return outputResponse;
}

int getSuggestFromPlayer()
{
    Console.WriteLine("Bir sayı giriniz");

    int number = 0;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Lütfen sadece sayı girin...");
    }
    return number;
}

int getRandomNumber(int min, int max)
{
    return new Random().Next(min, max);
}

bool isEven(int number)
{
    return number % 2 == 0;
}

void sendEmail(string email)
{
    Console.WriteLine("Farz et ki burada mail gitti :)");
}

int findMinimumNumbersIn(List<int> numbers)
{
    int min = numbers[0];
    foreach (int number in numbers)
    {
        if (min > number)
        {
            min = number;
        }
    }
    return 0;



}


enum CompareResult
{
    Equal,
    Big,
    Small
}