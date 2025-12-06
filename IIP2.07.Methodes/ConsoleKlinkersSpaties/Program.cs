using System;
using System.Text;
using System.Diagnostics.Metrics;

namespace Program;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Geef een tekst: ");
        string tekst = Console.ReadLine();

        Console.WriteLine($@"
deze tekst bevat {AantalKlinkers(tekst)} klinkers en {AantalSpaties(tekst)} spaties
in geheimschrift: {NaarGeheimschrift(tekst)} ");

        Console.ReadKey();
    }

    private static bool IsKlinker(char letter)
    {
        return letter == 'a' || letter == 'A' || letter == 'e' || letter == 'E' ||
               letter == 'i' || letter == 'I' || letter == 'o' || letter == 'O' ||
               letter == 'u' || letter == 'U';
    }

    private static int AantalSpaties(string tekst)
    {
        int aantal = 0;

        foreach (char c in tekst)
        {
            if (c == ' ')
            {
                aantal++;
            }
        }
        return aantal;
    }

    private static int AantalKlinkers(string tekst)
    {
        int aantal = 0;

        foreach (char c in tekst)
        {
            if (IsKlinker(c))
            {
                aantal++;
            }
        }
        return aantal;
    }

    private static string NaarGeheimschrift(string tekst)
    {
        char[] resultaat = new char[tekst.Length];

        for (int i = 0; i < tekst.Length; i++)
        {
            char c = tekst[i];

            if (c == ' ')
            {
                resultaat[i] = ' ';
            }
            else
            {
                resultaat[i] = (char)((int)c + 1);
            }
        }
        return new string(resultaat);
    }
}