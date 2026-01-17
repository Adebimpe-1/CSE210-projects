using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;
        Random rand = new Random();

        while (playAgain)
        {
            int magicNumber = rand.Next(1, 101);
            int guess = 0;
            int attempts = 0;

            Console.WriteLine("Let's play Guess My Number! Think of a number between 1 and 100.");

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = Convert.ToInt32(Console.ReadLine());
                attempts++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            Console.WriteLine($"You got it in {attempts} guesses!");

            Console.Write("Do you want to play again (yes/no)? ");
            string response = Console.ReadLine().Trim().ToLower();
            playAgain = (response == "yes");
        }
    }
}