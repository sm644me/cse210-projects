using System;

// Define a PromptGenerator class, which will be used to
// pick a prompt.
public class PromptGenerator
{
    // Member variables begin with an underscore.
    public List<string> _prompts = new List<string>();

    // Constructor method. For now, the list of prompts is hardcoded.
    // If this program were expanded, more methods could be used to get prompts.
    public PromptGenerator()
    {
        _prompts = ["Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What did I do to help someone else today?",
        "What did I accomplish today?",
        "How did I find happiness today?",
        "How did I bring joy to others today?",
        "What obstacle did I overcome today?",
        "Did anything big happen today? If not, why?"];
    }

    // Pick a prompt from the list!
    public string ChoosePrompt()
    {
        var random = new Random();
        int i = random.Next(_prompts.Count);
        return _prompts[i];
    }
}