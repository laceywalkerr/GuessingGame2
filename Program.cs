using System;

namespace GuessingGame2
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = new Random().Next(1, 100);
            Console.WriteLine(secretNumber);

            int attempts = 5;

            for (int i = 0; i < attempts; i++)
            {

                Console.Write($"Can you guess the number I'm thinking of? You have { attempts - i - 1} guesses to get it right! ");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Number guessed: {userNumber}");
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