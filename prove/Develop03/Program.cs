using System;
using System.Collections.Concurrent;

// CREATIVITY BONUS
// 1. The function to hide words considers which words are already hidden.
// 2. The user can type 'restart' to unhide all words.
// 3. The user can input how many words to hide per round.

class Program
{
    static void ExitProgram()
    {
        // Simply exit the entire program.
        // I'm sure there's a better way to break the loop later...
        // But I don't know what it is yet.
        System.Environment.Exit(1);
    }
    // Create a scripture from a simple reference string.
    static Scripture GenerateScripture(string refString)
    {
        Scripture scripture = new Scripture(refString);
        return scripture;
    }
    static void Main(string[] args)
    {
        // Setup for the main program.
        string SCRIPTURE_REFERENCE = "Proverbs 3:5-6";
        int words_to_hide = 3;
        Scripture scripture = GenerateScripture(SCRIPTURE_REFERENCE);
        bool isActive = true;

        // Enter the main loop.
        while (isActive)
        {
            Console.Clear();
            scripture.DisplayWords();
            Console.WriteLine("\nOptions:\nPress enter to continue.\nType 'restart' to display all words.\nType 'hide' and a number to set how many words will become hidden each round.\nType 'quit' to finish.\n");
            string userInput = Console.ReadLine();
            if (userInput == "restart")
            {
                scripture.UnhideAllWords();
                continue;
            }
            else if (userInput.Split(' ')[0] == "hide")
            {
                words_to_hide = int.Parse(userInput.Split(' ')[1]);
                continue;
            }
            if (scripture.GetIsHidden() || (userInput == "quit"))
            {
                Console.Clear();
                ExitProgram();
            }
            scripture.HideRandomWords(words_to_hide);
            Console.Clear();
        }
    }
}