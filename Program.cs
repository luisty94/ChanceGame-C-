using System;
namespace ChanceGame
{
    class Program
    {

        static void Main(string[] args)

        {

            Random random = new Random();

            int returnValue = random.Next(1, 99);

            int Guess = 0;
            int numGuesses = 0;

            Console.WriteLine("I'm thinking of a number between 1-99.  Which number is it?");
           
            while (Guess != returnValue)
            {
                numGuesses++;
                Guess = Convert.ToInt32(Console.ReadLine());
                if (Guess < returnValue)
                {
                    Console.WriteLine("No, the number is higher than " + Guess + ". Try again");
                }
                else if (Guess > returnValue)
                {
                    Console.WriteLine("No, the number is lower than " + Guess + ". Try again");
                }
            if (numGuesses == 5)
                {
                    Console.WriteLine("Sorry, the number was " + returnValue + ".");
                }
            }
           

            Console.WriteLine("Good Job! The answer was " + returnValue + "!");
            Console.ReadLine();

        }
    }
}
