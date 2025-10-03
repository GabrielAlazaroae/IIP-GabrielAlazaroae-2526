using System;

namespace ConsoleLeeftijd
{
   class Program
   {
      static void Main(string[] args)
      {
		Console.Write("Wat is je voornaam?: ");
		string voornaam = Console.ReadLine();
		Console.Write("Hoe oud ben je?: ");
		int leeftijd = Convert.ToInt32(Console.ReadLine()); 
		Console.Write("Geef je lievelingsletter:");
		string letter = Console.ReadLine();
		Console.WriteLine($"Hallo {voornaam} ! Jij bent {leeftijd} jaar");
		Console.WriteLine($"Volgend jaar ben je {leeftijd + 1} ");
		Console.WriteLine($"Jouw lievelingsletter is : {letter}");
		Console.ReadKey();
      }
   }
}