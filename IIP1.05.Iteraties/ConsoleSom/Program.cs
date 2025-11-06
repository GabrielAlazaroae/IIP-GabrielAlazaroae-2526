using System;


class Program
{
    static void Main(string[] args)
    {
        int som = 0;
        string input = "";

        while (input != "q")
        {
            Console.Write("Voer een getal in (q om te stoppen): ");
            input = Console.ReadLine();

            if (input == "q")
            {
                break;
            }

            int getal = Convert.ToInt32(input);
            som += getal;
        }

        Console.WriteLine("De som is: " + som);

        Console.ReadKey();
    }
}
