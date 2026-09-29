using System;

// Define a Job class, which will be used to record
// a person's job history.
public class Job
{
    // Member variables begin with an underscore.
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;

    // Constructor method.
    public Job()
    {
    }

    // Display relevant information.
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}