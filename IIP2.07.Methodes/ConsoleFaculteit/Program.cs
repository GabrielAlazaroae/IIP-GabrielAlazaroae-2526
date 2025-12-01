using System;
using System.Text;

namespace Program;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("FACULTEIT BEREKENEN");
        Console.Write("Geef een geheel getal: ");
        int getal = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"De faculteit is {Faculteit(getal)}");
        Console.ReadKey();
    }

    private static int Faculteit(int n)
    {
        int resultaat = 1;

        for (int i = n; i >= 1; i--)
        {
            resultaat *= i;
        }
        return resultaat;
    }
}