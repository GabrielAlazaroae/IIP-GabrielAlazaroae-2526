using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hoeveel seconden tot lancering? ");
        int seconden = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine("for-versie: ");
        for (int i = seconden; i >= 1; i--)
        {
            Console.WriteLine(i + "...");   
        }
        Console.WriteLine("Lift off!");

        Console.WriteLine();
        Console.WriteLine("do-while versie: ");
        int teller = seconden;
        do
        {
            Console.WriteLine(teller + "...");
            teller--;
        } while (teller >= 1);
        Console.WriteLine("Lift off!");

        Console.WriteLine();
        Console.WriteLine("while versie: ");
        int compteur = seconden;
        while (compteur >= 1)
        {
            Console.WriteLine(compteur + "...");
            compteur--;
        }
        Console.WriteLine("Lift off");

        Console.ReadKey();
    }
}