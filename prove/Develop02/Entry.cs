using System;

// Define an Entry class, which will be used to record
// a single journal entry.
public class Entry
{
    // Member variables begin with an underscore.
    public string _prompt = "";
    public string _response = "";
    public DateTime _date = new DateTime();

    // Constructor method.
    public Entry()
    {
    }

    // Display relevant information.
    public void Display()
    {
        Console.WriteLine($"{_date.ToShortDateString()}\nPrompt: \"{_prompt}\"\nResponse: \"{_response}\"");
    }

    // Create an entry!
    public void Create(string prompt_string = "")
    {
        // If called without a prompt, generate a random one.
        if (prompt_string == "")
        {
            PromptGenerator generator = new PromptGenerator();
            prompt_string = generator.ChoosePrompt();
        }
        
        // Sync the temporary variable with the member variable.
        _prompt = prompt_string;

        Console.Write($"Prompt: \"{_prompt}\" ");
        _response = Console.ReadLine();
        _date = DateTime.Now;
    }
}