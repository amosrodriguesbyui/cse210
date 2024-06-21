using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        int number = -1;

        while (number != 0)
        {
            Console.WriteLine("Enter a list of number, type 0 when finished.");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is {sum}:");

        
        float average = sum / numbers.count;
        Console.WriteLine($"The average is {average}:")       
    }
}