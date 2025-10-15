using System;
using System.Text;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string naam = "Bobby Peru";
        bool gehuwd = false;
        string telefoon = "0486/33.22.19";
        int leeftijd = 25;
        double salaris = 2500.00;
        string geslacht = "m";
        double lengte = 1.75;

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("*");
        Console.WriteLine($"* Naam: {naam}");
        Console.WriteLine($"* Gehuwd: {gehuwd}");
        Console.WriteLine($"* Telefoon: {telefoon}");
        Console.WriteLine($"* Leeftijd: {leeftijd} jaar");
        Console.WriteLine($"* Salaris: € {salaris:N2} per maand");
        Console.WriteLine($"* Geslacht: {geslacht}");
        Console.WriteLine($"* Lengte: {lengte:m}");
        Console.WriteLine($"*");
        Console.WriteLine($"~~~~~~~~~~~~~~~~~~~~");
    }
}