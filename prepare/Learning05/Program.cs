using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square s1 = new Square("red", 3.2);
        shapes.Add(s1);

        Rectangle r1 = new Rectangle("blue", 5, 4.5);
        shapes.Add(r1);

        Circle c1 = new Circle("black", 4);
        shapes.Add(c1);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"{color} is the color it has an area of {area}");
        }
    }
}