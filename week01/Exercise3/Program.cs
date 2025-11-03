using System;

class Program
{
    static void Main(string[] args)
    {
        int guessedNumber = 0;
        int attempts = 0;
        bool keepPlaying = true;

        while (keepPlaying)
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);
            do
            {
                Console.Write("What is your guess? ");
                guessedNumber = int.Parse(Console.ReadLine());
                attempts++;

                if (guessedNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guessedNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it! it took you {attempts} guesses");
                }

            } while (guessedNumber != magicNumber);

            Console.Write("Do you want to play again (Y/N)? ");
            string keepGoing = Console.ReadLine().ToLower();

            if (keepGoing == "n" || keepGoing == "no")
            {
                Console.WriteLine("Thanks for playing!");
                keepPlaying = false;
            }
        }

        
    }
}