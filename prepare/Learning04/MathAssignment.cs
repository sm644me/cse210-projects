using System;

// Define a MathAssignment class, which
// should be self-explanatory.
public class MathAssignment : Assignment
{
    // Member variables begin with an underscore.
    private string _textbookSection = "";
    private string _problems = "";

    // Constructor method.
    public MathAssignment(string name, string topic, string section, string problems) : base(name, topic)
    {
        _textbookSection = section;
        _problems = problems;
    }

    // Display relevant information.
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}