using System;
using System.Text;
using System.Collections.Generic;

namespace ConsoleWeerstation
{
    class Program
    {
        static double[] LeesTemperaturen()
        {
            string[] dagen = { "maandag", "dinsdag", "woensdag", "donderdag", "vrijdag", "zaterdag", "zondag" };
            
            double[] temperaturen = new double[7];
            
            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Temperatuur op {dagen[i]} (°C): ");
                temperaturen[i] = Convert.ToDouble(Console.ReadLine());
            }
            
            return temperaturen;
        }
        
        static void ToonWeekOverzicht(double[] temperaturen)
        {
            string[] dagen = { "maandag", "dinsdag", "woensdag", "donderdag", "vrijdag", "zaterdag", "zondag" };
            
            Console.WriteLine("WEEKOVERZICHT");
            Console.WriteLine("=============");
            
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"{dagen[i],-12}: {temperaturen[i],5:F1}°C");
            }
        }
        
        static double BerekenGemiddelde(double[] temperaturen)
        {
            double som = 0;
            
            for (int i = 0; i < temperaturen.Length; i++)
            {
                som += temperaturen[i];
            }
			
            return som / temperaturen.Length;
        }
         
        static int ZoekWarmsteDag(double[] temperaturen)
        {
            double hoogste = temperaturen[0];
            int index = 0;
            
            for (int i = 1; i < temperaturen.Length; i++)
            {
                if (temperaturen[i] > hoogste)
                {
                    hoogste = temperaturen[i];
                    index = i;
                }
            }
            
            return index;
        }
        
        static int ZoekKoudsteDag(double[] temperaturen)
        {
            double laagste = temperaturen[0];
            int index = 0;
            
            for (int i = 1; i < temperaturen.Length; i++)
            {
                if (temperaturen[i] < laagste)
                {
                    laagste = temperaturen[i];
                    index = i;
                }
            }
            
            return index;  
        }
        
        static string ZoekDagenOnderDrempel(double[] temperaturen, double drempel)
        {
            string[] dagen = { "maandag", "dinsdag", "woensdag", "donderdag", "vrijdag", "zaterdag", "zondag" };
            string koudeDagen = "";
            
            for (int i = 0; i < temperaturen.Length; i++)
            {
                if (temperaturen[i] < drempel)
                {
                    if (koudeDagen != "")
                    {
                        koudeDagen += ", ";
                    }
                    koudeDagen += dagen[i];
                }
            }
            
            return koudeDagen;
        }

        static void Main(string[] args)
        {
            string[] dagen = { "maandag", "dinsdag", "woensdag", "donderdag", "vrijdag", "zaterdag", "zondag" };
			
            double[] temperaturen = LeesTemperaturen();
            
			Console.WriteLine();
            ToonWeekOverzicht(temperaturen);
            
			Console.WriteLine();
            double gemiddelde = BerekenGemiddelde(temperaturen);
            Console.WriteLine($"Gemiddelde weektemperatuur: {gemiddelde:F1}°C");
            
            int warmsteIndex = ZoekWarmsteDag(temperaturen);
            int koudsteIndex = ZoekKoudsteDag(temperaturen);
            
            Console.WriteLine($"Warmste dag: {dagen[warmsteIndex]} ({temperaturen[warmsteIndex]:F1}°C)");
            Console.WriteLine($"Koudste dag: {dagen[koudsteIndex]} ({temperaturen[koudsteIndex]:F1}°C)");
            
			Console.WriteLine();
            Console.Write("Geef een drempeltemperatuur voor koude dagen: ");
            double drempel = Convert.ToDouble(Console.ReadLine());
            
            string koudeDagen = ZoekDagenOnderDrempel(temperaturen, drempel);
            
            if (koudeDagen != "")
            {
                Console.WriteLine($"Koude dagen (onder {drempel}°C): {koudeDagen}");
            }
            else
            {
                Console.WriteLine("Geen koude dagen gevonden.");
            }
            
			Console.WriteLine();
            Console.WriteLine("Druk op Enter om het programma te sluiten.");
            Console.ReadKey();
        }
    }
}