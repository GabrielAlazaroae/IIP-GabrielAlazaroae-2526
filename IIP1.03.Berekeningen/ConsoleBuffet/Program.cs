using System;
using System.Text;

class Program
{
   static void Main(string[] args)
   {
	    System.Globalization.CultureInfo.CurrentCulture = new System.Globalization.CultureInfo("fr-BE");
		
		const double season = 18.5;
        const double desert = 7.95;
        const double kinderen = 8.95;

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(
@"WELKOM IN HET BUFFETRESTAURANT
==============================

Alles is à volonté en dranken zijn inbegrepen!
!!Promotie!! Vaandag ronden we het totaalbedrag af naar beneden!");
        Console.ResetColor();

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        Console.Write($"Aantal seizoensbuffets (€{season}): ");
        int seizoen = Convert.ToInt32(Console.ReadLine());
        double aantalSeizoenen = season * seizoen;
        Console.Write($"Aantal dessertenbuffets (€{desert}): ");
        int dessert = Convert.ToInt32(Console.ReadLine());
        double aantalDesserten = desert * dessert;
        Console.Write($"Aantal Kids menus (€{kinderen}): ");
        int kids = Convert.ToInt32(Console.ReadLine());
        double aantalKids = kinderen * kids;

        Console.WriteLine();
        Console.Write("Fooi (0 indien geen): ");
        double fooi = Convert.ToDouble(Console.ReadLine());

        double total = aantalSeizoenen + aantalDesserten + aantalKids + fooi;
        int totalRound = Convert.ToInt32(Math.Floor(total));

        Console.WriteLine($"Totaal te betalen: € {total}");
        Console.WriteLine($"Afgerond naar beneden: € {totalRound}");

        Console.WriteLine();
        Console.Write("Cash betaald: €");
        int cash = Convert.ToInt32(Console.ReadLine());
        int wisselgeld = cash - totalRound;
        Console.Write($"U krijgt terug: €{wisselgeld}");
        Console.WriteLine();
        int briefjes50 = wisselgeld / 50;
        wisselgeld = wisselgeld % 50;
        Console.WriteLine($"- {briefjes50} briefje(s) van 50");
        int briefjes20 = wisselgeld / 20;
        wisselgeld = wisselgeld % 20;
        Console.WriteLine($"- {briefjes20} briefje(s) van 20");
        int briefjes10 = wisselgeld / 10;
        wisselgeld = wisselgeld % 10;
        Console.WriteLine($"- {briefjes10} briefje(s) van 10");
        int briefjes5 = wisselgeld / 5;
        wisselgeld = wisselgeld % 5;
        Console.WriteLine($"- {briefjes5} briefje(s) van 5");
        int stukken2 = wisselgeld / 2;
        wisselgeld = wisselgeld % 2;
        Console.WriteLine($"- {stukken2} briefje(s) van 2");
        int stukken1 = wisselgeld / 1;
        wisselgeld = wisselgeld % 1;
        Console.WriteLine($"- {stukken1} briefje(s) van 1");
        Console.ReadKey();
   }
}