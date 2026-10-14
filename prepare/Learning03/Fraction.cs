using System;

// Define a Fraction class, which will
// store parts of a fraction and display them.
public class Fraction
{
    // Member variables begin with an underscore.
    private int _top = 0;
    private int _bottom = 0;

    // Constructor method. Default to 1/1.
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Basic Getters and Setters.
    public int GetBottom()
    {
        return _bottom;
    }
    public int GetTop()
    {
        return _top;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    public void SetTop(int top)
    {
        _top = top;
    }

    // Fancier return values!
    public string GetFractionString()
    {
        string output = GetTop() + "/" + GetBottom();
        return output;
    }
    public double GetDecimalValue()
    {
        double output = GetTop() / (double)GetBottom();
        return output;
    }
}