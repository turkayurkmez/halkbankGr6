// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string[] words = { "Mikrofon", "Klavye", "Mouse", "Kamera" };


for (int index = 0; index < words.Length; index++)
{
    Console.WriteLine(words[index]);
}

DateTime finishDate = new DateTime(2023, 12, 31);
for (DateTime startDate = new DateTime(2023, 1, 1); startDate <= finishDate; startDate = startDate.AddDays(1))
{
    Console.WriteLine(startDate.ToLongDateString());
}