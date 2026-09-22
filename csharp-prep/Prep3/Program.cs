using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a random number.
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guessInt = -1;
        do
        {
            Console.WriteLine("What is your guess? ");
            string guessString = Console.ReadLine();
            guessInt = int.Parse(guessString);
            if (guessInt < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guessInt > magicNumber)
            {
                Console.WriteLine("Lower");
            }
        } while (guessInt != magicNumber);
        Console.WriteLine("You guessed it!");
    }
}