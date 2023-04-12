// See https://aka.ms/new-console-template for more information
Console.WriteLine("Kullanıcı adınızı giriniz!");
string userName = Console.ReadLine();
Console.WriteLine("Şifreniz...");
string password = Console.ReadLine();

if (userName == "turkay" && password == "123")
{
    Console.WriteLine("Hoşgeldin Türkay!");
}
else if (userName == "nihanece" && password == "987")
{
    Console.WriteLine("Hoşgeldin Nihan Ece!");
}
else
{
    Console.WriteLine("Tanınmıyor");
}


if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
{
    Console.WriteLine("Haftasonu");

}
else
{
    Console.WriteLine("Hafta içi!");
}

int x = 100;
bool thesis1 = x <= 50;
bool thesis2 = x >= 50;
bool thesis3 = x > 55;
bool notEqual = x != 50;//(! =);


