// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Random random = new Random();
int target = random.Next(0, 100);
int x = 0;
bool isGameOver = false;
while (!isGameOver)
{
    Console.WriteLine("Sayıyı tahmin edin:");
    int suggest = Convert.ToInt32(Console.ReadLine());
    if (suggest > target)
    {
        Console.WriteLine("Aşağı!");
    }
    else if (suggest < target)
    {
        Console.WriteLine("Yukarı");
    }
    else
    {
        Console.WriteLine("Bildiniz!");
        isGameOver = true;
    }
}
