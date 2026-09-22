using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        // Initialize a list and variable.
        List<int> numbers = new List<int>();
        int userInput = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (userInput != 0)
        {
            Console.Write("Enter number: ");
            string inputString = Console.ReadLine();
            userInput = int.Parse(inputString);
            if (userInput != 0)
            {
                numbers.Add(userInput);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        numbers.Sort();
        int largest = numbers[numbers.Count - 1];
        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}