using System;


namespace prepApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo(); // Run GetAppInfo function to get App information

            GreetUser(); // Ask user's name and greet user

            while (true)
            {


                // Init correct number
                // int correctNumber = 5;

                //Create a random object
                Random random = new Random();

                // Init correct number
                int correctNumber = random.Next(1, 10);



                // Init guess var
                int guess = 0;

                // Ask user to guess a number
                Console.WriteLine("Guess a number between 1 and 10");

                // If user's guess is incorrect
                while (guess != correctNumber)
                {
                    // Get user's  input
                    string input = Console.ReadLine();

                    // Ensure that the user's input is a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Change text Color
                        Console.ForegroundColor = ConsoleColor.Red;

                        // Tell user that input isnot a number
                        Console.WriteLine("Please enter an actual number");

                        // Reset text color
                        Console.ResetColor();
                        // Tell user to keep playing
                        continue;
                    }
                    // Cast to int and put into guess
                    guess = Int32.Parse(input);
                    // Match user's guess to the correct number
                    if (guess != correctNumber)
                    {
                        // Change text Color
                        Console.ForegroundColor = ConsoleColor.Red;

                        // Tell user that number guessed is wrong
                        Console.WriteLine("Wrong number, guess again!");

                        // Reset text color
                        Console.ResetColor();

                    }
                }

                // Output sucessful message
                // Change text Color
                Console.ForegroundColor = ConsoleColor.Yellow;

                // Tell user that number guessed is correct
                Console.WriteLine("Correct!!!!, you rock!!!");

                // Reset text color
                Console.ResetColor();

                // Ask user if they want to play again
                Console.WriteLine("Would you like to play again? [Y or N]");

                // Get user's answer
                string answer = Console.ReadLine().ToUpper();

                // Check if user's answer is a Yes or No
                if(answer == "Y") {
                    continue;
                }
                else if(answer == "N") {
                    return;
                }
                else 
                {
                    return;
                }


            }
        }

        // Function to get App Info
        static void GetAppInfo() {
            // Set App Variables
            String appName = "Guessing Game";
            String appVersion = "1.0.0";
            String appAuthor = "Oby Ogbutor";

            // Change text Color
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2} ", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }

        static void GreetUser() { 
            // Ask user's name
            Console.WriteLine("What is your name?");

            // Obtain user's input
            String inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, Let's play a game ...",inputName);
        }

    }
}
