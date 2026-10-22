using System;
using System.Xml;

// Define a Word class, which contains
// text and a visibility toggle.
public class Word
{
    // Member variables begin with an underscore.
    private bool _isHidden = false;
    private string _text = "";

    // Constructor method. You must provide a word with text. Hidden is false by default.
    public Word(string text, bool hidden = false)
    {
        _isHidden = hidden;
        _text = text;
    }

    // Retrieve the text in whatever form it takes.
    public string GetWord()
    {
        string text = _text;
        if (_isHidden)
        {
            int len = text.Length;
            text = new string('_', len);
        }
        return text;
    }
    public bool GetIsHidden()
    {
        return _isHidden;
    }

    // Toggle the word's visibility!
    // Yes, this is arguably too many functions for a simple feature.
    // But I think the principle here is sound.
    public void ToggleHidden()
    {
        if (_isHidden)
        {
            UnhideWord();
        }
        else
        {
            HideWord();
        }
    }
    private void HideWord()
    {
        _isHidden = true;
    }
    private void UnhideWord()
    {
        _isHidden = false;
    }
}