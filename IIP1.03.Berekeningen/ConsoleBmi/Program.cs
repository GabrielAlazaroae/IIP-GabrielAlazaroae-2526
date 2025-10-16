using System;
using System.Text;

class Program
{
   static void Main(string[] args)
   {
		Console.WriteLine("BMI CALCULATOR");
        Console.WriteLine("==============");

        Console.Write("Lengte (in cm): ");
        double lengte = Convert.ToInt32(Console.ReadLine());

        Console.Write("Gewicht(in kg): ");
        int gewicht = Convert.ToInt32(Console.ReadLine());

        double lengteInMeters = (lengte / 100);
        double bmi = gewicht / Math.Pow(lengteInMeters, 2);

        double bmiRound = Math.Round(bmi, 1);
        Console.WriteLine($"Je BMI bedraagt: {bmiRound}");

        Console.ReadKey();
   }
}