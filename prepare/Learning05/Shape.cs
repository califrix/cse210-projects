using System;
using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public abstract class Shape
{
    private string _color;

    public string GetColor()
    {
        
        return _color;
    }

    public Shape(string color)
    {
        _color = color;
    }

    public abstract double GetArea();
    
}