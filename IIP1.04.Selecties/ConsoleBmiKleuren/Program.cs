using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("BMI CALCULATOR");
        Console.WriteLine("==============");

        Console.Write("Lengte (in cm): ");
        double lengte = Convert.ToDouble(Console.ReadLine());

        Console.Write("Gewicht(in kg): ");
        int gewicht = Convert.ToInt32(Console.ReadLine());

        double lengteInMeters = (lengte / 100);
        double bmi = gewicht / Math.Pow(lengteInMeters, 2);

        double bmiRound = Math.Round(bmi, 1);
        Console.WriteLine($"Je BMI bedraagt: {bmiRound}");

        if (bmiRound < 18.5)
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Je hebt ondergewicht");
            Console.ResetColor();
        }
        else if (bmiRound >= 18.5 && bmiRound <= 25)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Je gewicht is normaal");
            Console.ResetColor();
        }
        else if (bmiRound >= 25 && bmiRound <= 30)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Je hebt overgewicht");
            Console.ResetColor();
        }
        else if (bmiRound > 30)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Je hebt obesitas");
            Console.ResetColor();
        }

        Console.ReadKey();
    }
}