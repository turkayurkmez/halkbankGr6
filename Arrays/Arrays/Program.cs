// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//1. Kaç elemanlı olduğunu biliyorum ama elemanları bilmiyorum.
string[] students = new string[20];
students[0] = "Türkay";
students[19] = "Hatice";
//2. Tüm elemanları biliyorum:
string[] seasons = new string[] { "İlkbahar", "Yaz", "Sonbahar", "Kış" };
Console.WriteLine(seasons[0]);
Console.WriteLine(seasons[seasons.Length - 1]);

/*
 * Kullanıcının  girdiği iki basamaklı bir sayının OKUNUŞUNU yazsın.
 * 42
 * Kırk iki
 * 
 * 56 124 243
 * 
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Sayı giriniz:");
        string input = Console.ReadLine();
        string[] ones = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
        string[] tens = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
        string[] thousandsGroups = { "", "bin", "milyon", "milyar", "trilyon", "katrilyon" };

        int inputLength = input.Length;
        if (inputLength == 0)
        {
            Console.WriteLine("Lütfen bir sayı girin.");
            return;
        }
        if (inputLength > 18)
        {
            Console.WriteLine("Lütfen daha küçük bir sayı girin.");
            return;
        }

        bool isNegative = (input[0] == '-');
        if (isNegative)
        {
            input = input.Substring(1);
            inputLength--;
        }
        if (inputLength == 0)
        {
            Console.WriteLine("Lütfen bir sayı girin.");
            return;
        }

        int[] groups = new int[(inputLength + 2) / 3];
        for (int i = 0; i < groups.Length; i++)
        {
            groups[i] = int.Parse(input.Substring(Math.Max(inputLength - 3 * (i + 1), 0), Math.Min(3, inputLength - 3 * i)));
        }

        string[] groupsText = new string[groups.Length];
        for (int i = 0; i < groups.Length; i++)
        {
            int group = groups[i];
            if (group > 0)
            {
                int hundreds = group / 100;
                int tensUnits = group % 100;
                if (hundreds == 1 && tensUnits == 0)
                {
                    groupsText[i] = "yüz";
                }
                else
                {
                    groupsText[i] = (hundreds > 0 ? ones[hundreds] + " yüz " : "") + (tensUnits > 0 ? tens[tensUnits / 10] + " " + ones[tensUnits % 10] : "");
                }
                if (i != 0)
                {
                    groupsText[i] += " " + thousandsGroups[i];
                }
            }
        }

        string result = string.Join(" ", groupsText).Trim();
        if (isNegative)
        {
            result = "eksi " + result;
        }
        Console.WriteLine(result);
    }
}

//sen varya sen az çakal çççççç ççççç 
//
//Console.WriteLine($"{onlar[onlarBasamagindakiSayi]} {birler[birBasamagindakiSayi]}");

//for (int i = 1; i < 100; i++)
//{
//    number = i;
//    int onlarBasamagindakiSayi2 = number / 10;
//    int birBasamagindakiSayi2 = number % 10;
//    Console.WriteLine($"{onlar[onlarBasamagindakiSayi2]} {birler[birBasamagindakiSayi2]}");
//}




