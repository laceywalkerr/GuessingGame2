﻿using System;

namespace GuessingGame2
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = new Random().Next(1, 101);
            int attempts = 0;
            int attemptsAllowed = GetNumberOfAttempts();

            Console.WriteLine($"TESTING NUMBER: {secretNumber}");

            while (attempts < attemptsAllowed || attemptsAllowed == -1)
            {
                // the $ in front of the string to summon the info is a "string interpolation"
                Console.Write($"Can you guess the number I'm thinking of? You have ({ attemptsAllowed - attempts }) guesses to get it right!  ");
                string userResponse = Console.ReadLine();
                int userNumber = int.Parse(userResponse);
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
                    attempts++;

                    if (attemptsAllowed == -1)
                    {
                        Console.WriteLine("Take your time :] ");
                    }
                    else
                    {
                        Console.WriteLine($"You have {attemptsAllowed - attempts} guesses left");
                    }
                }
            }
        }

        static int GetNumberOfAttempts()
        {
            int attempts = 0;
            while (attempts == 0)
            {
                Console.Write("What difficulty would you like to select? (easy, medium, hard): ");
                string userResponse = Console.ReadLine().ToLower();

                switch (userResponse)
                {
                    case ("easy"):
                        attempts = 8;
                        break;

                    case ("medium"):
                        attempts = 6;
                        break;

                    case ("hard"):
                        attempts = 4;
                        break;

                    case ("cheater"):
                        attempts = -1;
                        break;

                    default:
                        break;
                }
            }
            return attempts;
        }
    }

}