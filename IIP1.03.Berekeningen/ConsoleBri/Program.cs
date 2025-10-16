using System;
using System.Text;

class Program
{
   static void Main(string[] args)
   {
		Console.WriteLine(
@"BRI CALCULATOR 🏋
=================");

        const double basis = 364.2;
        const double factor = 365.5;

        const double ondergrens = 3.41;
        const double bovengrens = 4.44;

        Console.WriteLine();
                
        Console.Write("Taille (in cm): ");
        double taille = Convert.ToDouble(Console.ReadLine());

        Console.Write("Lengte (in cm): ");
        double lengte = Convert.ToDouble(Console.ReadLine());

        double piXheight = Math.PI * lengte;
        double ratio = taille / piXheight;
        double ratioSquared = Math.Pow(ratio, 2);
        double squared = 1 - ratioSquared;
        double racine = Math.Sqrt(squared);
        double factorXracine = factor * racine;
        double bri = basis - factorXracine;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Je BRI bedraagt: {bri:F1}");
        Console.ResetColor();

        Console.WriteLine();
        Console.WriteLine($"Een BRI tussen {ondergrens} en {bovengrens} is normaal.");
        Console.ReadKey();
   }
}