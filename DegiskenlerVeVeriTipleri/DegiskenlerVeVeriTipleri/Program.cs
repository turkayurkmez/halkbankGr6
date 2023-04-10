// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
 * Sayısal
 * Sözel
 * Mantıksal
 */

//Matematik ...... Sayısal
/*
 * Tam sayılar
 * Ondalıklı
 */

byte enKucukSayisal = 255;

sbyte negatif = -128;

short onaltiBit = 32767;
ushort x = 65535;

int otuzikiBit = 2120524000;
uint y = 4000000000;

long altmisDort = 9223372036854775807;
ulong enBuyukTamSayi = 0;



double pi = 3.14;
float fPi = 3.14f;
decimal decimalPi = 3.1459000001255415654455466698944236874400000000000000000000887888478887745896140000000000000000000000000000000000000000000000000000488944888778855501104488M;

//Sözel
char symbol = '!';
string kelime = "Türkay Merhaba !";
String word = "";

//Mantıksal
bool isOk = false;

byte deger1 = 255;
byte deger2 = 4;

checked
{
    byte sonuc = (byte)(deger1 + deger2);
    Console.WriteLine(sonuc);
}

