// See https://aka.ms/new-console-template for more information
Console.WriteLine("Lütfen bir sayı giriniz");

try
{
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("İkinci bir sayı daha giriniz");
    //string value2 = Console.ReadLine();
    int number2 = int.Parse(Console.ReadLine());
    int division = number1 / number2;
    Console.WriteLine($"{number1} sayısının {number2} sayısına bölümü: {division} ");


}
catch (FormatException)
{
    Console.WriteLine("Lütfen sadece sayısal değer giriniz!");

}
catch (DivideByZeroException)
{
    Console.WriteLine("Tam sayılar 0'a bölünemez!");
}
catch (Exception ex)
{
    Console.WriteLine($"Bir hata oluştu. Gelen mesaj:{ex.Message}");
}
finally
{

    //Örnek: dosya burada kapanıyor.
    Console.WriteLine("dosya kapandı");
}
