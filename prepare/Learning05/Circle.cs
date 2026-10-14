using System;

public class Circle : Shape
{
    private double _diameter;

    public Circle(string color, double diameter) : base(color)
    {
        _diameter =  diameter;
    }

    public override double GetArea()
    {
        return Math.PI * _diameter;
    }
}