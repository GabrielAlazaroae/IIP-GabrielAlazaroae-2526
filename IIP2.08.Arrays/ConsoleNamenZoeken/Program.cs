using System;
namespace iip;

class Program
{
    static void Main(string[] args)
    {
        // Array avec les noms
        string[] namen = { "Elias", "Fatima", "Noah", "Aisha", "Liam", "Sofia", "Kenji", "Mila", "Omar", "Yara" };
        
        bool doorgaan = true;
        
        while (doorgaan)
        {
            // Afficher le menu
            Console.Clear();
            Console.WriteLine("==== MENU ====");
            Console.WriteLine("a. Controleer of naam bestaat");
            Console.WriteLine("b. Zoek volgnummer van naam");
            Console.WriteLine("c. Zoek naam op woord");
            Console.WriteLine("d. Zoek naam op lengte");
            Console.WriteLine("e. Afsluiten");
            Console.WriteLine();
            Console.Write("Maak een keuze: ");
            
            string keuze = Console.ReadLine().ToLower();
            Console.WriteLine();
            
            switch (keuze)
            {
                case "a":
                    NaamBestaat(namen);
                    break;
                case "b":
                    ZoekOpLengte(namen);
                    break;
                case "c":
                    ZoekVolgnummer(namen);
                    break;
                case "d":
                    ZoekOpWoord(namen);
                    break;
                case "e":
                    doorgaan = false;
                    Console.WriteLine("Programma wordt afgesloten...");
                    break;
                default:
                    Console.WriteLine("Ongeldige keuze!");
                    break;
            }
            
            if (doorgaan)
            {
                Console.WriteLine();
                Console.WriteLine("Druk op een toets om verder te gaan...");
                Console.ReadKey();
            }
        }
    }
    
    static void NaamBestaat(string[] namen)
    {
        Console.Write("Naam: ");
        string zoekNaam = Console.ReadLine();
        
        bool gevonden = false;
        foreach (string naam in namen)
        {
            if (naam.Equals(zoekNaam, StringComparison.OrdinalIgnoreCase))
            {
                gevonden = true;
                break;
            }
        }
        
        if (gevonden)
        {
            Console.WriteLine($"'{zoekNaam}' komt voor in de lijst");
        }
        else
        {
            Console.WriteLine($"'{zoekNaam}' is niet gevonden");
        }
    }
    
    static void ZoekOpLengte(string[] namen)
    {
        Console.Write("Lengte: ");
        int lengte = int.Parse(Console.ReadLine());
        
        bool gevonden = false;
        for (int i = 0; i < namen.Length; i++)
        {
            if (namen[i].Length == lengte)
            {
                Console.WriteLine($"Naam met {lengte}: {namen[i]}");
                gevonden = true;
            }
        }
        
        if (!gevonden)
        {
            Console.WriteLine($"Geen naam gevonden met {lengte}");
        }
    }
    
    static void ZoekVolgnummer(string[] namen)
    {
        Console.Write("Naam: ");
        string zoekNaam = Console.ReadLine();
        
        int positie = -1;
        for (int i = 0; i < namen.Length; i++)
        {
            if (namen[i].Equals(zoekNaam, StringComparison.OrdinalIgnoreCase))
            {
                positie = i;
                break;
            }
        }
        
        if (positie >= 0)
        {
            Console.WriteLine($"'{zoekNaam}' is gevonden op positie {positie}");
        }
        else
        {
            Console.WriteLine($"'{zoekNaam}' is niet gevonden");
        }
    }
    
    static void ZoekOpWoord(string[] namen)
    {
        Console.Write("Zoekwoord: ");
        string zoekwoord = Console.ReadLine();
        
        bool gevonden = false;
        foreach (string naam in namen)
        {
            if (naam.Contains(zoekwoord, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"'{naam}' gevonden voor '{zoekwoord}'");
                gevonden = true;
            }
        }
        
        if (!gevonden)
        {
            Console.WriteLine($"Geen naam gevonden voor '{zoekwoord}'");
        }
    }
}