// using System;

// namespace GuessingGame
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Random r = new Random();
//             int secretNumber = r.Next(1, 101);
//             int numberOfAttempts = 0;
//             int attemptsAllowed = GetNumberOfAttempts();

//             while (numberOfAttempts < attemptsAllowed)
//             {
//                 Console.Write($"Guess a friggen number ({numberOfAttempts + 1}): ");
//                 string userResponse = Console.ReadLine();
//                 int guess = int.Parse(userResponse);

//                 if (guess == secretNumber)
//                 {
//                     Console.WriteLine("Ya! You guessed it!");
//                     break;
//                 }
//                 else
//                 {
//                     Console.WriteLine("Nope that wasn't it...");
//                     if (guess > secretNumber)
//                     {
//                         Console.WriteLine("Your guess was too high");
//                     }
//                     else
//                     {
//                         Console.WriteLine("Your guess was too low");
//                     }
//                     numberOfAttempts++;
//                 }
//             }
//         }

//         static int GetNumberOfAttempts()
//         {
//             int numberOfAttempts = 0;
//             while (numberOfAttempts == 0)
//             {
//                 Console.Write("What difficulty setting? (easy, medium, hard): ");
//                 string userResponse = Console.ReadLine().ToLower();

//                 switch (userResponse)
//                 {
//                     case ("easy"):
//                         numberOfAttempts = 8;
//                         break;
//                     case ("medium"):
//                         numberOfAttempts = 6;
//                         break;
//                     case ("hard"):
//                         numberOfAttempts = 4;
//                         break;
//                     default:
//                         break;
//                 }
//             }
//             return numberOfAttempts;
//         }
//     }
// }