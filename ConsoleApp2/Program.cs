using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            double odds = .75;

            Guy player = new Guy() { Cash = 100, Name = "The player" };

            Console.WriteLine("Welcome to the Game. The Odds are " + odds);
        }
    }
}
