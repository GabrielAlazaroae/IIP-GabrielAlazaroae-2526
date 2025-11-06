using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Geef een tekst: ");
        string tekst = Console.ReadLine();

        int aantalKlinkers = 0;
        int aantalSpaties = 0;

        foreach (char letter in tekst)
        {
            int asciiWaarde = (int)letter;

            if (asciiWaarde == 97 || asciiWaarde == 101 || asciiWaarde == 105 ||
                    asciiWaarde == 111 || asciiWaarde == 117 ||
                    asciiWaarde == 65 || asciiWaarde == 69 || asciiWaarde == 73 ||
                    asciiWaarde == 79 || asciiWaarde == 85)
            {
                aantalKlinkers++;
            }

            if (asciiWaarde == 32)
            {
                aantalSpaties++;
            }
        }
        Console.WriteLine($"Deze tekst bevat {aantalKlinkers} klinkers en {aantalSpaties} spaties");

        string geheimschrift = "";
        foreach (char letter in tekst)
        {
            if (letter != ' ')
            {
                geheimschrift += char.ToUpper(letter);
            }
        }

        Console.WriteLine($"in geheimschrift: {geheimschrift} ");

        Console.ReadKey();
    }
}
