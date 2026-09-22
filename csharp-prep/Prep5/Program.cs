using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int PromptUserBirthYear(out int year)
    {
        Console.Write("Please enter your birth year: ");
        year = int.Parse(Console.ReadLine());
        return year;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResult(string name, int number, int year)
    {
        Console.WriteLine($"{name}, your squared number is {number}.");
        year = 2026 - year;
        Console.WriteLine($"{name}, you will turn {year} this year.");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int year = PromptUserBirthYear(out year);
        int square = SquareNumber(number);
        DisplayResult(name, square, year);
    }
}