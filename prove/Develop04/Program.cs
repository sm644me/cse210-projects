using System;

// CREATIVITY BONUS - When random prompts are called, they won't be duplicates of previous prompts until all have been used.

class Program
{
    static void ExitProgram()
    {
        // Simply exit the entire program.
        // I'm sure there's a better way to break the loop later...
        // But I don't know what it is yet.
        System.Environment.Exit(1);
    }
    static void Main(string[] args)
    {
        // Define the activities.
        BreathingActivity act1 = new BreathingActivity();
        ReflectingActivity act2 = new ReflectingActivity();
        ListingActivity act3 = new ListingActivity();
        
        // Define the main menu and all of its choices and actions.
        List<string> menuOptions = ["Start breathing activity", "Start reflecting activity",
        "Start listing activity", "Quit"];
        List<Action> menuActions = [act1.Run, act2.Run,
        act3.Run, ExitProgram];
        Menu mainMenu = new Menu(menuOptions, menuActions);

        // Initialization.
        bool isActive = true;
        Console.WriteLine("Welcome to the Mindfulness Program!");

        // Begin the main program loop!
        // This is only a single statement.
        // All functionality is handled with methods.
        while (isActive)
        {
            mainMenu.DisplayAndRun();
        }
    }
}