using System;

namespace PickRandomCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of cards to pick: ");

            string line = Console.ReadLine();

            if (int.TryParse(line, out int numberOfCards))
            {
                string[] cards = CardPicker.PickSomeCards(numberOfCards);

                foreach(string card in cards)
                {
                    Console.WriteLine(card);
                }
            } 
            else
            {
                Console.WriteLine("This is not a valid number !");
            }
        }
    }
}
