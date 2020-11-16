using System;

namespace GuessingGame2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Can you guess the number I'm thinking of?");
            string number = Console.ReadLine();
            Console.WriteLine($"You guessed {number}? Oh, Okay.");
        }
    }
}