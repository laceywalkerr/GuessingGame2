using System;

namespace GuessingGame2
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = new Random().Next(1, 101);
            Console.WriteLine(secretNumber);

            int attempts = 5;
            // int attempts = 0;

            for (int i = 0; i < attempts; i++)
            // while (attempts < 4)
            {
                // the $ in front of the string to summon the info is a "string interpolation"
                Console.Write($"Can you guess the number I'm thinking of? You have { attempts - i - 1} guesses to get it right! ");
                // {attempts + 1}
                int userNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Number guessed: {userNumber}");

                // the code below is an example of a conditional
                if (secretNumber == userNumber)
                {
                    Console.WriteLine("SUCCESS! You got it, dude!");
                    break;
                }
                else if (secretNumber != userNumber)
                {
                    if (userNumber < secretNumber)
                    {
                        Console.WriteLine("Try guessing a little higher!");
                    }
                    else
                    {
                        Console.WriteLine("Try guessing a little lower!");
                    }
                }
            }
        }
    }
}