using System;

class NumberGuessingGame
{
    static void Main()
    {
        // Initialize random number generator
        Random random = new Random();

        // Generate a random number between 1 and 100
        int targetNumber = random.Next(1, 101);
        int userGuess = 0; // Variable to store the user's guess
        int attempts = 0;  // Counter for the number of attempts

        Console.WriteLine("Welcome to the Number Guessing Game!");
        Console.WriteLine("I have picked a number between 1 and 100. Can you guess what it is?");
       
        // Main game loop
        while (userGuess != targetNumber)
        {
            Console.Write("Enter your guess: ");
           
            // Try to parse the user's input as an integer
            if (int.TryParse(Console.ReadLine(), out userGuess))
            {
                attempts++; // Increment the attempts counter

                if (userGuess < targetNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (userGuess > targetNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    // User guessed the correct number
                    Console.WriteLine($"Congratulations! You guessed the number in {attempts} attempts.");
                }
            }
            else
            {
                // Handle invalid input
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        // End of game
        Console.WriteLine("Thank you for playing!");
    }
