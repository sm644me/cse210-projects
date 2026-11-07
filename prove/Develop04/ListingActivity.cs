// Define a specific activity. Only one instance of each should be needed.
public class ListingActivity : Activity
{
    // Member variables begin with an underscore.
    private List<string> _prompts = [];
    private List<string> _usedPrompts = [];

    // Constructor method.
    public ListingActivity(string name="Listing Activity", string desc="This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") : base(name, desc)
    {
        _prompts = ["Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"];
    }

    // Main function.
    public void Run()
    {
        StartActivity();
        Opener();

        DateTime currentTime = DateTime.Now;
        DateTime endTime = GetEndTime(currentTime);

        int count = 0;

        while (currentTime < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
            currentTime = DateTime.Now;
        }
        Console.WriteLine($"You listed {count} items!");
        EndActivity();
    }
    // Display some opening stuff for this one before starting.
    public void Opener()
    {
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        string prompt = GetRandomFromList(_prompts, _usedPrompts);
        Console.WriteLine($" --- {prompt} --- ");
        Console.Write("You may begin in: ");
        PauseWithCountdown(5);
        Console.Write("\n");
    }
}