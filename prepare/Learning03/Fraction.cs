public class Fraction
{
    private int _top;
    private int _bottom;

// constructor with no paramtr
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

// top parameter only
    public Fraction(int numerator)
    {
        _top = numerator;
        _bottom = 1;
    }

    // 2 parameters
    public Fraction(int numerator, int denominator)
    {
        _top = numerator;
        _bottom = denominator;
    }

    public void Display()
    {
        Console.WriteLine($"{_top}/{_bottom}");
    }

    public int GetTopNum()
    {
        return _top;
    }

    public void SetTopNumber(int topNumber)
    {
        _top = topNumber;  
    }

    public double GetDecimal()
    {
        return (double)_top/ (double)_bottom;
    }

}