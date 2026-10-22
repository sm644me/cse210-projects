using System;
using System.Reflection;

// Define a Reference class, which stores
// reference info. Obviously.
public class Reference
{
    // Member variables begin with an underscore.
    private string _book = "";
    private int _chapter = 0;
    private int _verse = 0;
    private int _endVerse = 0;

    // Constructor methods. _endVerse is optional.
    public Reference(string refString)
    {
        List<string> refList = refString.Split(' ', '-', ':').ToList();
        if (refList.Count == 3)
        {
            refList.Add(refList[2]);
        }
        _book = refList[0];
        _chapter = int.Parse(refList[1]);
        _verse = int.Parse(refList[2]);
        _endVerse = int.Parse(refList[3]);
    }
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
    }
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    // Format the reference title properly.
    public string GetReferenceTitle()
    {
        string title = $"{_book} {_chapter}:{_verse}";
        if (_verse != _endVerse)
        {
            title += $"-{_endVerse}";
        }
        return title;
    }
    // Get the full text of the reference.
    // In a hypothetical advanced version of this program, it would look up the text from a full source.
    // Here, it only checks a selection of verses from Proverbs 3.
    public string GetReferenceText()
    {
        List<string> verses = ["My son, forget not my law; but let thine heart keep my commandments:",
        "For length of days, and long life, and peace, shall they add to thee.",
        "Let not mercy and truth forsake thee: bind them about thy neck; write them upon the table of thine heart:",
        "So shalt thou find favour and good understanding in the sight of God and man.",
        "Trust in the Lord with all thine heart; and lean not unto thine own understanding.",
        "In all thy ways acknowledge him, and he shall direct thy paths.",
        "Be not wise in thine own eyes: fear the Lord, and depart from evil.",
        "It shall be health to thy navel, and marrow to thy bones."];
        string text = verses[_verse - 1];
        if (_verse != _endVerse)
        {
            for (int i = _verse + 1 ; i <= _endVerse; i++ )
            {
                text = text.Remove(text.Length -1, 1) + "; ";
                text += verses[i - 1];
            }
        }
        return text;
    }
}