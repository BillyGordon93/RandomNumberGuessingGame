using System;
using System.Collections.Generic;

namespace RandomNumberGuessingGame
{
    class Program
    {
        static int randomNumber = 0;
        static Random rng = new Random();
        static void Main(string[] args)
        {
                bool playAgain = true;
            do
            {
                WelcomeText();
                randomNumber = GetRandomNumber();
                int userNumber = GetUserNumber(Console.ReadLine());

                while (userNumber != randomNumber)
                {
                    CheckUserGuess(ref userNumber, randomNumber);
                }

                Console.WriteLine("You were correct!");
                Console.WriteLine($"Would you like to play again? yes/no");
                if (Console.ReadLine().ToLower() == "yes")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            } while (playAgain == true);
        }

        private static int GetRandomNumber()
        {
            return rng.Next(1, 101);
        }

        static int GetUserNumber(string userInput)
        {
            return int.Parse(userInput);
        }
        static void CheckUserGuess(ref int userNumber, int randomNumber)
        {
            if (userNumber < randomNumber)
            {
                Console.WriteLine("To low, guess again!");
                userNumber = GetUserNumber(Console.ReadLine());
            }
            else if (userNumber > randomNumber)
            {
                Console.WriteLine("To high, guess again!");
                userNumber = GetUserNumber(Console.ReadLine());
            }
        }
        static void WelcomeText()
        {
            Console.WriteLine("I am the number master!");
            Console.WriteLine("Welcome to the random number guessing game");
            Console.WriteLine("Choose a number between 1 and 100");
        }
    }
}
