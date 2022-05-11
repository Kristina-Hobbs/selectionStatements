using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the number guessing game!");


            var favNumber = 17;

            Console.WriteLine("Can you guess my favorite number?");
            string guess = Console.ReadLine();
            int userGuess = int.Parse(guess);

            bool condition = true;

            if(userGuess == favNumber)
            {
                Console.WriteLine("That is correct!");
            }
            else
            {
                Console.WriteLine("Thats not it, try again!");

            }
        }
    }
}
