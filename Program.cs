using System;

namespace GuessingGame2
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 42;
            Console.WriteLine(secretNumber);

            int attempts = 4;

            Console.Write($"Can you guess the number I'm thinking of? You have { attempts - 1} guesses left!");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine($"You guessed {userNumber}? Oh, Okay.");

            if (secretNumber == userNumber)
            {
                Console.WriteLine("SUCCESS! You got it, dude!");
            }
            else if (secretNumber != userNumber)
            {
                Console.WriteLine("Uhmm.. nah man. Try again.");
            }

        }
    }
}