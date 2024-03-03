using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");


         List<int> numbers = new List<int>();

        int numbersFromUser = -1;

         while (numbersFromUser != 0)
         {
            Console.Write("Enter the number in a list.");
            string getNumberFromUser = Console.ReadLine();
            numbersFromUser = int.Parse(getNumberFromUser);

            if (numbersFromUser != 0)
            {
                numbers.Add(numbersFromUser);
            }
         }

         int sum = 0;
         foreach (int number in numbers)
         {
            sum = sum + number;
         }
         Console.WriteLine($"The sum is: {sum}");

         float average = sum / numbers.Count;
         Console.WriteLine($"The average is: {average}");

         int max = numbers[0];
         foreach (int number in numbers)
         {
            if (number > max)
            {
                max = number;
            }
         }
         Console.WriteLine($"The largest number is: {max}");
    }
}