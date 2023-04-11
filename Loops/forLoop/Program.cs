// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string[] words = { "Mikrofon", "Klavye", "Mouse", "Kamera" };


for (int index = 0; index < words.Length; index++)
{
    Console.WriteLine(words[index]);
}

//DateTime finishDate = new DateTime(2023, 12, 31);
//for (DateTime startDate = new DateTime(2023, 1, 1); startDate <= finishDate; startDate = startDate.AddDays(1))
//{
//    Console.WriteLine(startDate.ToLongDateString());
//}

int[] numbers = { 56, 12, 45, -9, 0 };
int min = numbers[0];
for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
}

Console.WriteLine(min.ToString());

Console.WriteLine("Bir kelime giriniz");
string word = Console.ReadLine();

bool isFind = false;
for (int i = 0; i < words.Length; i++)
{
    if (words[i] == word)
    {
        isFind = true;
        break;
    }
}
//if (isFind)
//{
//   message = $"{word} Kelimesi array içinde var";
//}
//else
//{
//   message = $"{word} Kelimesi array içinde yok ";
//}
string state = string.Empty;
state = isFind ? "var" : "yok";
string message = $"{word} kelimesi array içinde {state}";
Console.WriteLine(message);
