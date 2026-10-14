using System;

public class Rectangle : Shape
{
    private double _top;
    private double _side;

    public Rectangle(string color, double top, double side) : base(color)
    {
        _top = top;
        _side = side;
    }

    public override double GetArea()
    {
        return _top * _side;
    }
}