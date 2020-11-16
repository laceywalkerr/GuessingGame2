using System;

namespace GuessingGame2
{
    class Program
    {
        static void Main(string[] args)
        {
            string SecretNumber = "42";
            Console.WriteLine(SecretNumber);

            Console.Write("Can you guess the number I'm thinking of? ");
            string UserNumber = Console.ReadLine();
            // Console.WriteLine($"You guessed {UserNumber}? Oh, Okay.");

            if (SecretNumber == UserNumber)
            {
                Console.WriteLine("SUCCESS! You got it, dude!");
            }
            else if (SecretNumber != UserNumber)
            {
                Console.WriteLine("Uhmm.. nah man. Try again.");
            }

        }
    }
}