using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random magicNumber = new Random();
        int magic = magicNumber.Next(1,11);

        int guess = 0;

        do
        {
            Console.WriteLine("What is your guess?");
            string guessNumber = Console.ReadLine();
            guess = int.Parse(guessNumber);
        
            if (magic > guess)
            {
                Console.WriteLine("Highier");
            }
            else if (magic < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guess it!");
            }
        } while (guess != magic);
    }
}