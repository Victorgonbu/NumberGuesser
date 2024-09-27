using System;
using System.Net.NetworkInformation;

// Namespace
namespace NumberGuesser
{ 
  // Main class
  class Program
    {
        // Entry point method
        static void Main(string[] args)
        {
            GetAppInfo(); // Run GetAppInfo to printout app information
            GreetUser(); // Asks user name and greet

            while (true)
            {
                // Set correct number
                // int correctNumber = 7;

                // Create a new random object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;


                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    // Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please enter an actual number");

                        // keep going
                        continue;
                    }

                    // Cast to in and put in guess
                    guess = Int32.Parse(input);
                    // Match guess to correct number

                    if (guess != correctNumber)
                    {
                        // Change Text color
                        Console.ForegroundColor = ConsoleColor.Red;

                        // Tell user its the wrong number
                        Console.WriteLine("Wrong number, please try again");

                        // Reset text color
                        Console.ResetColor();
                    }
                }

                // Change Text color
                Console.ForegroundColor = ConsoleColor.Yellow;

                // Tell user its the right number
                Console.WriteLine("You are correct!");

                // Reset text color
                Console.ResetColor();

                // Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }

        }

        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Number guesser";
            string appVersion = "1.0";
            string appAuthor = "Victor Gonzalez";

            // Change Text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }

        static void GreetUser()
        {
            // Asks users name
            Console.WriteLine("What's your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change Text color
            Console.ForegroundColor = color;

            // Tell user its not a number
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}