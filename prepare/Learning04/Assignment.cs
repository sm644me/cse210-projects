using System;

// Define an Assignment class, which
// contains generic info.
public class Assignment
{
    // Member variables begin with an underscore.
    private string _studentName = "";
    private string _topic = "";

    // Constructor method.
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    // Display relevant information.
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
    public string GetStudentName()
    {
        return _studentName;
    }
}