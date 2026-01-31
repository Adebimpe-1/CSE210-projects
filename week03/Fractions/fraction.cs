// File: Fraction.cs
public class Fraction
{
    private int _top;    // numerator
    private int _bottom; // denominator

    // No-arg constructor: initializes to 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // One-arg constructor: top provided, bottom defaults to 1
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // Two-arg constructor: top and bottom provided
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter for top (numerator)
    public int GetTop()
    {
        return _top;
    }

    // Setter for top
    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter for bottom (denominator)
    public int GetBottom()
    {
        return _bottom;
    }

    // Setter for bottom
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Returns the fraction as "top/bottom", e.g., "3/4"
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Returns the decimal value of the fraction as a double
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}