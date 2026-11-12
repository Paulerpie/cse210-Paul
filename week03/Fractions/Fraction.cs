using System;

public class Fraction {

    private int _topNumber;
    private int _bottomNumber;

    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }

    public Fraction(int topNumber)
    {
        _bottomNumber = 1;
        _topNumber = topNumber;
    }

    public Fraction(int topNumber, int bottomNumber)
    {
        _bottomNumber = bottomNumber;
        _topNumber = topNumber;
    }

    public int GetTopNumber()
    {
        return _topNumber;
    }

    public int GetBottomNumber()
    {
        return _bottomNumber;
    }

    public void SetBottomNumber(int bottomNumber)
    {
        _bottomNumber = bottomNumber;
    }

    public void SetTopNumber(int topNumber)
    {
        _topNumber = topNumber;
    }

    public string GetFractionString()
    {
        return $"{_topNumber}/{_bottomNumber}";
    }
    
    public double GetDecimalValue()
    {
        return (double)_topNumber / (double)_bottomNumber;
    }
}