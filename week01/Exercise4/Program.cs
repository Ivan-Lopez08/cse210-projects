using System;
using System.Data;
using System.Runtime.ExceptionServices;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int listNumber = 1;
        int largest = 0;
        int smallest = 9999;
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        while (listNumber != 0)
        {
            Console.Write("Enter a number: ");
            listNumber = int.Parse(Console.ReadLine());

            if (listNumber == 0)
            {
                continue;
            }
            else
            {
                numbers.Add(listNumber);
            }
        }

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
            if (number > largest)
            {
                largest = number;
            }

            if (number < smallest && number > 0)
            {
                smallest = number;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {sum / numbers.Count}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
        Console.WriteLine("The sorted list is: ");

        numbers.Sort();

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

    }
}