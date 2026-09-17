using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input a grade percentage. ");
        string gradeString = Console.ReadLine();
        int gradePercent = int.Parse(gradeString);

        // Cap the grade percentage to avoid silly situations.
        if (gradePercent > 100)
        {
            gradePercent = 100;
        }

        // Declare this variable, then define what it is.
        string gradeLetter = "UNDEFINED";

        if (gradePercent >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradePercent >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradePercent >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradePercent >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        // Add extra signs to the grade!
        if (gradePercent <= 95 && gradePercent >= 60)
        {
            int gradeLastDigit = gradePercent % 10;
            if (gradeLastDigit >= 7)
            {
                gradeLetter += "+";
            }
            else if (gradeLastDigit <= 3)
            {
                gradeLetter += "-";
            }
        }

        // Finally write a line.
        Console.WriteLine($"With a percentage of {gradePercent}%, your grade is {gradeLetter}!");
        if (gradePercent >= 70)
        {
            Console.WriteLine("Congratulations! You've passed the course!");
        }
        else
        {
            Console.WriteLine("Sorry, that grade isn't high enough to pass. Give it another try!");
        }
    }
}