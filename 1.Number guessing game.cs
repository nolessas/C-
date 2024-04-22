using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            string response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                    try
                    {
                        guess = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Guess: " + guess);

                        if (guess > number)
                        {
                            Console.WriteLine(guess + " is too high!");
                        }
                        else if (guess < number)
                        {
                            Console.WriteLine(guess + " is too low!");
                        }
                        guesses++;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input! You need to enter a number.");
                    }
                }

                Console.WriteLine("Number: " + number);
                Console.WriteLine("You win!");
                Console.WriteLine("Guesses: " + guesses);

                Console.WriteLine("Would you like to play again (Y/N): ");
                response = Console.ReadLine().Trim().ToUpper();

                playAgain = response == "Y";
            }

            Console.WriteLine("Thanks for playing!");
            Console.ReadKey();
        }
    }
}
