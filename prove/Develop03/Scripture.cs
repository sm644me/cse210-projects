using System;
using System.Diagnostics;

// Define a Scripture class, which will be used to hold
// many Word instances and a Raference.
public class Scripture
{
    // Member variables begin with an underscore.
    public List<Word> _words = new List<Word>();
    public Reference _reference;

    // Constructor methods.
    public Scripture(string refString)
    {
        _reference = new Reference(refString);
        SetWordsFromString(_reference.GetReferenceText());
    }
    public Scripture(Reference reference)
    {
        _reference = reference;
        SetWordsFromString(reference.GetReferenceText());
    }
    public Scripture(Reference reference, List<Word> words)
    {
        _reference = reference;
        _words = words;
    }

    // Set the words in the scripture in two ways!
    public void SetWordsFromList(List<Word> words)
    {
        _words = words;
    }
    public void SetWordsFromString(string words)
    {
        _words = [];
        List<string> rawResult = words.Split(' ').ToList();
        List<Word> newWords = new List<Word> {};
        foreach (string word in rawResult)
        {
            newWords.Add(new Word(word));
        }
        _words = newWords;
    }

    // Check if all the words are hidden.
    public bool GetIsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.GetIsHidden())
            {
                return false;
            }
        }
        return true;
    }

    // Display the full text!
    public void DisplayWords()
    {
        string text = _reference.GetReferenceTitle();
        text += " ";
        foreach (Word i in _words)
        {
            text += $"{i.GetWord()} ";
        }
        text = text.TrimEnd();
        Console.WriteLine(text);
    }

    // Toggle some words!
    public void HideRandomWords(int count = 3)
    {
        // Create a list of all non-hidden words.
        List<Word> potentialWords = new List<Word> {};
        foreach (Word word in _words)
        {
            if (!word.GetIsHidden())
            {
                potentialWords.Add(word);
            }
        }
        // Failsafe: Do not attempt to hide more words than can be hidden.
        if (count > potentialWords.Count)
        {
            count = potentialWords.Count;
        }
        // Finally, toggle visibility on random possible words.
        for (int i = 0; i < count; i++) 
        {
            Word word = SelectRandomWord(potentialWords);
            word.ToggleHidden();
            potentialWords.Remove(word);
        }
    }
    // Select one word at random.
    private Word SelectRandomWord(List<Word> words)
    {
        Random random = new Random();
        int i = random.Next(words.Count);
        return words[i];
    }
    // Make the words visible again!
    public void UnhideAllWords()
    {
        foreach (Word word in _words)
        {
            if (word.GetIsHidden())
            {
                word.ToggleHidden();
            }
        }
    }
}