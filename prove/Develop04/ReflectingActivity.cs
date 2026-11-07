// Define a specific activity. Only one instance of each should be needed.
public class ReflectingActivity : Activity
{
    // Member variables begin with an underscore.
    private List<string> _concepts = [];
    private List<string> _questions = [];
    private List<string> _usedConcepts = [];
    private List<string> _usedQuestions = [];

    // Constructor method.
    public ReflectingActivity(string name="Reflecting Activity", string desc="This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") : base(name, desc)
    {
        _concepts = ["Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."];
        _questions = ["Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"];
    }

    // Main function.
    public void Run()
    {
        StartActivity();
        Opener();

        DateTime currentTime = DateTime.Now;
        DateTime endTime = GetEndTime(currentTime);

        while (currentTime < endTime)
        {
            string question = GetRandomFromList(_questions, _usedQuestions);
            Console.Write($"\n{question} ");
            PauseWithSpinner(15);
            currentTime = DateTime.Now;
        }
        Console.Write("\n");
        EndActivity();
    }
    // Display some opening stuff for this one before starting.
    public void Opener()
    {
        Console.WriteLine("\nConsider the following prompt:\n");
        string concept = GetRandomFromList(_concepts, _usedConcepts);
        Console.WriteLine($" --- {concept} --- \n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Write("You may begin in: ");
        PauseWithCountdown(5);
        Console.Clear();
    }
}