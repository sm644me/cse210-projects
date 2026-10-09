using System;
using System.Net.NetworkInformation;

// CREATIVITY BONUS - I added several features.
// 1. I save the precise DateTime object. This includes saving it to a file and parsing it when the file is loaded.
// 2. The user can input a custom prompt to answer.

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
        // Define a journal that's going to be in use.
        Journal activeJournal = new Journal();
        
        // Define the main menu and all of its choices and actions.
        Menu mainMenu = new Menu();
        mainMenu._options = ["Write (Random Prompt)", "Write (Custom Prompt)", "Display", "Save", "Load", "Quit"];
        mainMenu._actions = [activeJournal.CreateEntry, activeJournal.CreateEntryWithPrompt,
        activeJournal.DisplayEntries, activeJournal.SaveToFile, activeJournal.LoadFromFile, ExitProgram];

        // Initialization.
        bool is_active = true;
        Console.WriteLine("Welcome to the Journal Program!");

        // Begin the main program loop!
        // This is only a single statement.
        // All functionality is handled with methods.
        while (is_active)
        {
            mainMenu.DisplayAndRun();
        }
    }
}