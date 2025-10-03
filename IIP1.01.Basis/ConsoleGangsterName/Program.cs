using System;

namespace ConsoleGangsterName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@$"
            **
            | GANGSTER NAME BUILDER|
            **"
            );
            Console.Write("Give me the first name of any Disney character: ");
            string disnename = Console.ReadLine();
            Console.Write("Give any workbench tool: ");
            string toolname = Console.ReadLine();
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();

            Console.Write("Your Gangster name:");
            Console.Write($@" {disnename} 'the {toolname} ' {name}");
            Console.ReadKey(); // Waits for user input before closing
        }
    }
}