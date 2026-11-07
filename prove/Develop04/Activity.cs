// Define an Activity class, which tracks
// general info for all activities.
// This should not be instantiated alone!

public class Activity
{
    // Member variables begin with an underscore.
    private string _name = "";
    private string _description = "";
    private int _duration = 0;

    // Constructor method.
    public Activity()
    {
    }
    public Activity(string name, string desc)
    {
        _name = name;
        _description = desc;
    }

    // Begin an activity!
    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine(_description);
        Console.Write($"\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine($"Get ready...");
        PauseWithSpinner(5);
    }
    // End an activity!
    public void EndActivity()
    {
        Console.WriteLine($"\nWell done!");
        PauseWithSpinner(3);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}.");
        PauseWithSpinner(5);
        Console.Clear();
    }
    // Get the time to end this activity.
    public DateTime GetEndTime(DateTime startTime)
    {
        DateTime endTime = startTime.AddSeconds(_duration);
        return endTime;
    }
    // Pause for a while, and count down too.
    public void PauseWithCountdown(int time=5)
    {
        while (time > 0)
        {
            Console.Write(time);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            time -= 1;
        }
    }
    // Pause for a while, but no countdown here!
    public void PauseWithSpinner(int time=5)
    {
        List<string> anim = ["-","\\","|","/"];
        int cTime = 1000 / anim.Count;
        while (time > 0)
        {
            foreach (string c in anim)
            {
                Console.Write(c);
                Thread.Sleep(cTime);
                Console.Write("\b \b");
            }
            time -= 1;
        }
    }
    // Choose something from a list. Avoid duplicates.
    public string GetRandomFromList(List<string> list, List<string> used_list)
    {
        if (used_list.Count() >= list.Count())
        {
            used_list.Clear();
        }
        Random random = new Random();
        List<string> working = new List<String>(list);
        foreach (string str in used_list)
        {
            working.Remove(str);
        }
        int i = random.Next(working.Count);
        used_list.Add(working[i]);
        return working[i];
    }
}