using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string gradeFromUser = Console.ReadLine();
        int grade = int.Parse(gradeFromUser);

        string letter = "";

        if (grade >= 0 && grade < 60)
        {
            letter = "F";
        }
        else if (grade >= 60 && grade < 70)
        {
            letter = "D";
        }
        else if (grade >= 70 && grade < 80)
        {
            letter = "C";
        }
        else if (grade >= 80 && grade < 90)
        {
            letter = "B";
        }
        else if (grade >= 90 && grade <= 100)
        {
            letter = "A";
        }
        else
        {
            Console.WriteLine("Invalid value.");
        }

        Console.WriteLine($"Your grade is {letter}.");


        if (grade >= 70 && grade <= 100)
        {
            Console.WriteLine("Congratulation, you pass.");
        }
        else if (grade >= 0 && grade < 70)
        {
            Console.WriteLine("Best lack for other time.");
        }
        else
        {
            Console.WriteLine("Nothing to present.");
        }
    }
}