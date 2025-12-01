using System;
using System.Text;

namespace Program;


class Program
{
    static void Main(string[] args)
    {
        int jaartal;

        Console.WriteLine(@"
SCHRIKKELJAAR
=============");

        do
        {
            Console.Write("Geef een jaartal: ");
            jaartal = Convert.ToInt32(Console.ReadLine());

            if (jaartal != 0)
            {
                if (Schrikkeljaar(jaartal))
                {
                    Console.WriteLine($"Het jaar {jaartal} is een schrikkeljaar.");
                }
                else
                {
                    Console.WriteLine($"Het jaar {jaartal} is geen schrikkeljaar.");
                }
            }
        } while (jaartal != 0);
        Console.ReadKey();
    }

    private static bool Schrikkeljaar(int jaar)
    {
        if (jaar % 400 == 0)
        {
            return true;
        }
        else if (jaar % 100 == 0)
        {
            return false;
        }
        else if (jaar % 4 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}