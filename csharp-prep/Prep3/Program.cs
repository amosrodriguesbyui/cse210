using System;

class Program
{


    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        Console.WriteLine($"The random magic number: {magicNumber}");

        int guessNumber = -1;

        do
        {
            Console.Write("What is your guess num? ");
            string getNumberFromUser = Console.ReadLine();
            guessNumber = int.Parse(getNumberFromUser);

            if (magicNumber > guessNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guessNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Congratulation, you guess it.");
            }
        } while (magicNumber != guessNumber);
    }
}