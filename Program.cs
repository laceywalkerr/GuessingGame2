﻿using System;

namespace GuessingGame2
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 42;
            Console.WriteLine(secretNumber);

            int attempts = 4;

            for (int i = 0; i < attempts; i++)
            {

                Console.Write($"Can you guess the number I'm thinking of? You have { attempts - i - 1} guesses to get it right! ");
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
}