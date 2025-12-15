using System;

namespace iip
{
    class Program
    {
        static void Main(string[] args)
        {
            const int AantalDagen = 7;
            double[] temperaturen = new double[AantalDagen];
            
            for (int i = 0; i < AantalDagen; i++)
            {
                Console.Write($"Geef de temperatuur op voor dag {i + 1}: ");
                temperaturen[i] = double.Parse(Console.ReadLine());
            }
            
            double hoogsteTemp = temperaturen[0];
            for (int i = 1; i < AantalDagen; i++)
            {
                if (temperaturen[i] > hoogsteTemp)
                {
                    hoogsteTemp = temperaturen[i];
                }
            }
            
            double laagsteTemp = temperaturen[0];
            for (int i = 1; i < AantalDagen; i++)
            {
                if (temperaturen[i] < laagsteTemp)
                {
                    laagsteTemp = temperaturen[i];
                }
            }
            
            double somTemperaturen = temperaturen[0];
            for (int i = 1; i < AantalDagen; i++)
            {
                somTemperaturen = somTemperaturen + temperaturen[i];
            }
            
            double gemiddeldeTemp = somTemperaturen / AantalDagen;
            
            Console.WriteLine();
            Console.Write("Temperaturen deze week: ");
            foreach (double temp in temperaturen)
            {
                Console.Write($"{temp:F1}°C ");
            }
            
            Console.WriteLine();
            Console.WriteLine($"Gemiddelde temperatuur: {gemiddeldeTemp:F2}°C");
            Console.WriteLine($"Hoogste temperatuur: {hoogsteTemp:F1}°C");
            Console.WriteLine($"Laagste temperatuur: {laagsteTemp:F1}°C");
            
            Console.ReadKey();
        }
    }
}