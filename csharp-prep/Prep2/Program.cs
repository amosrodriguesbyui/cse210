using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("What is your grade percentage?");
        string gradePercentage = Console.ReadLine();
        int number = int.Parse(gradePercentage);

        string letter = " ";
        string sign = " ";
        
        if (number >= 90 && number <= 100)
        {
            letter = "A";
        }
        else if (number >= 80 && number < 90)
        {
            letter = "B";
        }
        else if (number >= 70 && number < 80)
        {
            letter = "C";
        }
        else if (number >= 60 && number < 70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int lastDigit = number % 10;
        if (lastDigit >= 7 && !(number < 60 || number >= 93))
        {
            sign = "+";
        }
        else if (lastDigit < 3 && !(number <= 60 || number > 93))
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is {letter}{sign}");

        if (number >= 70)
        {
            Console.WriteLine("Congratulations! You pass the class.");
        }
        else
        {
            Console.WriteLine("You will have to try harder than that! Better luck next time.");
        }
    }
}