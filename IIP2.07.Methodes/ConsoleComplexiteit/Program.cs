using System;
using System.Text;

namespace Program;

class Program
{
    static void Main(string[] args)
    {
        string woord;
        do
        {
            Console.Write("Geef een woord (enter om te stoppen): ");
            woord = Console.ReadLine();

            if (woord != "")
            {
                Console.WriteLine($@"
aantal karakters: {woord.Length}
aantal lettergrepen: {AantalLettergrepen(woord)}
complexiteit: {Complexiteit(woord):F1} ");
            }
            Console.WriteLine();
        } while (woord != "");

        Console.WriteLine("Bedankt en tot ziens.");
        Console.ReadKey();
    }

    private static bool IsKlinker(char letter)
    {
        return letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u';
    }

    private static int AantalLettergrepen(string woord)
    {
        int aantalGroepen = 0;
        bool vorigeKlinker = false;

        foreach (char c in woord)
        {
            if (IsKlinker(c) && !vorigeKlinker)
            {
                aantalGroepen++;
            }
            vorigeKlinker = IsKlinker(c);
        }

        return aantalGroepen;
    }

    private static double Complexiteit(string woord)
    {
        int aantalLetters = woord.Length;
        int aantalGroepen = AantalLettergrepen(woord);
        int bonus = 0;

        if (woord.Contains('q'))
        {
            bonus++;
        }
        if (woord.Contains('x'))
        {
            bonus++;
        }
        if (woord.Contains('y'))
        {
            bonus++;
        }

        return (double)aantalLetters / 3 + aantalGroepen + bonus;
    }
}
