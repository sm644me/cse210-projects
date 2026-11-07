// Define a specific activity. Only one instance of each should be needed.
public class BreathingActivity : Activity
{
    // Member variables begin with an underscore. If they exist. Which they don't.

    // Constructor method.
    public BreathingActivity(string name="Breathing Activity", string desc="This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.") : base(name, desc)
    {
    }

    // Main function.
    public void Run()
    {
        StartActivity();

        DateTime currentTime = DateTime.Now;
        DateTime endTime = GetEndTime(currentTime);

        while (currentTime < endTime)
        {
            Console.Write("\nBreathe in...");
            PauseWithCountdown(4);
            Console.Write("\nNow breathe out...");
            PauseWithCountdown(6);
            Console.Write("\n");
            currentTime = DateTime.Now;
        }
        EndActivity();
    }
}