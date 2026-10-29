using System;

class Program
{
    static void Main(string[] args)
    {
        // Define a student to use.
        string STUDENT = "Mary Waters";

        // Test generic assignment.
        Assignment assignment1 = new Assignment(STUDENT, "Multiplication");
        Console.WriteLine($"{assignment1.GetSummary()}");

        // Create assignments.
        MathAssignment math1 = new MathAssignment(STUDENT, "Fractions", "7.3", "9-18");
        WritingAssignment writing1 = new WritingAssignment(STUDENT, "European History", "The Causes of World War II");

        // Print info.
        Console.WriteLine($"{math1.GetSummary()}\n{math1.GetHomeworkList()}");
        Console.WriteLine($"{writing1.GetSummary()}\n{writing1.GetWritingInformation()}");
    }
}