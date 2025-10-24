using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("__________    _____  ________  ___________ _______   \n\\______   \\  /  _  \\ \\______ \\ \\_   _____/ \\      \\  \n |       _/ /  /_\\  \\ |    |  \\ |    __)_  /   |   \\ \n |    |   \\/    |    \\|    `   \\|        \\/    |    \\\n |____|_  /\\____|__  /_______  /_______  /\\____|__  /\n        \\/         \\/        \\/        \\/         \\/ ");

        Console.WriteLine("Geef twee gehele getallen");
        Console.Write("- Getal 1: ");
        int getal1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("- Getal 2: ");
        int getal2 = Convert.ToInt32(Console.ReadLine());

        int tmp;

        if (getal1 > getal2)
        {
            tmp = getal1;
            getal1 = getal2;
            getal2 = tmp;
        }

        Random generator = new Random();
        int generatedNumber = generator.Next(getal1, getal2 + 1);

        Console.WriteLine($"Even denken... ja, ik heb een getal tussen {getal1} en {getal2} in mijn hoofd.");
        Console.Write("Doe een gok: ");
        int gokgetal = Convert.ToInt32(Console.ReadLine());

        if (gokgetal == generatedNumber)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("JUIST");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("FOUT");
            Console.ResetColor();

            int verschil = Math.Abs(gokgetal - generatedNumber);

            if (verschil <= 2)
            {
                Console.WriteLine("Je zat er nochtans niet ver af");
            }
        }

        Console.ReadKey();
    }
}