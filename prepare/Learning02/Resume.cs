using System;

// Define a Resume class, which will be used to hold
// many Job instances at once.
public class Resume
{
    // Member variables begin with an underscore.
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    // Constructor method.
    public Resume()
    {
    }

    // Display relevant information.
    public void Display()
    {
        Console.WriteLine($"Name: {_name}\nJobs:");
        foreach (Job j in _jobs)
        {
            j.Display();
        }
    }
}