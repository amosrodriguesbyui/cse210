using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        string playAgain = "yes";

        while (playAgain == "yes")
        {            
            Random magicNumber = new Random();
            int magic = magicNumber.Next(1,11);

            int guess = -1;
            int count = 0;

            do
            {
                Console.WriteLine("What is your guess?");
                string guessNumber = Console.ReadLine();
                guess = int.Parse(guessNumber);

                count = count + 1;
            
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
                    Console.WriteLine($"It took you {count} time of guess.");
                }
            } while (guess != magic);

            Console.WriteLine("Do you want to play again (yes/no)?");
            playAgain = Console.ReadLine();
        }
        Console.WriteLine("Thanks for playing. Goodbye.");
    }
}