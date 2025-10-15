using System;

namespace ConsoleContactCard;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bestelgegevens");
        Console.WriteLine("================");

        Console.Write("- naam klant: ");
        string naam = Console.ReadLine();

        Console.Write("- aantal toegeangsbeurten: ");
        int aantal = Convert.ToInt32(Console.ReadLine());

        Console.Write("- Prijs (b.v. 122,5): ");
        double prijs = Convert.ToDouble(Console.ReadLine());

        Console.Write("- badkledij inbegrepen (typ true of false): ");
        bool kledij = Convert.ToBoolean(Console.ReadLine());

        Console.Write("- geslacht (druk 'm' of 'v'): ");
        char geslacht = Console.ReadKey().KeyChar;
        Console.WriteLine();

        Random rnd = new Random();
        int getal1 = rnd.Next(0, 10);
        int getal2 = rnd.Next(0, 10);
        int getal3 = rnd.Next(0, 10);
        int getal4 = rnd.Next(0, 10);
        int getal5 = rnd.Next(0, 10);
        int getal6 = rnd.Next(0, 10);
        int getal7 = rnd.Next(0, 10);
        int getal8 = rnd.Next(0, 10);
        int getal9 = rnd.Next(0, 10);
        string kaartnummer = ($"{getal1}{getal2}{getal3}-{getal4}{getal5}{getal6}{getal7}-{getal8}{getal9}");

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Samenvatting");
        Console.WriteLine("============");
        Console.WriteLine($@"
- houder: {naam}
- geslacht: {geslacht}
- prijs {prijs}
- aantal beurten: {aantal}
- incl- badkledij: {kledij}
- kaartnummer: {kaartnummer}");

        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine("druk op een toets om verder te gaan...");
        Console.ReadKey();
    }
}
