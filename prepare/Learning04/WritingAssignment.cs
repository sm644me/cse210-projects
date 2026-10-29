using System;

// Define a WritingAssignment class, which
// should be self-explanatory.
public class WritingAssignment : Assignment
{
    // Member variables begin with an underscore.
    private string _title = "";

    // Constructor method.
    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    // Display relevant information.
    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
}