using System;
using System.Collections.Generic;

namespace RandomNumberGuessingGame
{
    class Program
    {
        static Random rng = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("I am the number master!"); 
            Console.WriteLine("Welcome to the random number guessing game");
            Console.WriteLine("Choose a number between 1 and 100");
            
            int randomNumber = rng.Next(1, 101);
            int userNumber = int.Parse(Console.ReadLine());
            do
            {               
                if (userNumber < randomNumber)
                {
                    Console.WriteLine("To low, guess again!");
                    userNumber = int.Parse(Console.ReadLine());
                }
                else if (userNumber > randomNumber)
                {
                    Console.WriteLine("To high, guess again!");
                    userNumber = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("You were incorrect!");
                    Console.WriteLine("The correct number was: " + randomNumber);
                }
            } while (userNumber != randomNumber);
            
             Console.WriteLine("You were correct!");
            
        }
    }
}
