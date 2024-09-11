using System.Dynamic;

namespace Temperatures
{
    internal class Program
    {
        static void Main(string[] args)
        {              
             String? userInput;

            do
            {
                Console.WriteLine("Vänligen ange temperaturen i grader Celcius.");
                int temp = Convert.ToInt32(Console.ReadLine());
                

                if (temp >= 30)
                {
                    Console.WriteLine("Jättevarmt!", Console.ForegroundColor = ConsoleColor.Red);
                }

                else if (temp >= 20 && temp <= 29)
                {
                    Console.WriteLine("Varmt!", Console.ForegroundColor = ConsoleColor.Yellow);
                }

                else
                {
                    Console.WriteLine("Hösttemperatur", Console.ForegroundColor = ConsoleColor.Blue);
                }

                Console.WriteLine("Skriv exit för att avsluta programmet, annars tryck valfri knapp och enter för att fortsätta.", Console.ForegroundColor = ConsoleColor.White);
                userInput = Console.ReadLine();
            }

            while (userInput != "exit");
            


        }
    }
}
