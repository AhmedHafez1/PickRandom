using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guy ahmed = new Guy() { Cash = 50, Name = "Ahmed" };

            Guy mohamed = new Guy() { Cash = 100, Name = "Mohamed" };

            while (true)
            {
                ahmed.WriteMyInfo();
                mohamed.WriteMyInfo();

                Console.Write("Enter an amount: ");
                string howMuch = Console.ReadLine();
                if (howMuch == "") return;

                bool isValidAmount = int.TryParse(howMuch, out int amount);

                if (isValidAmount)
                {
                    Console.Write("Who should give the cash: ");
                    string whichGuy = Console.ReadLine();
                    if (whichGuy == "Ahmed")
                    {
                        int givenCash = ahmed.GiveCash(amount);
                        mohamed.ReceiveCash(givenCash);
                    }
                    else if (whichGuy == "Mohamed")
                    {
                        int givenCash = mohamed.GiveCash(amount);
                        ahmed.ReceiveCash(givenCash);
                    }
                    else
                    {
                        Console.WriteLine("Please enter 'Ahmed' or 'Mohamed'");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an amount (or a blank line to exit).");
                }
            }
        }
    }
}
