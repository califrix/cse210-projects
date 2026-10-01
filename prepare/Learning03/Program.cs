using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac1 = new Fraction();
        Console.WriteLine(frac1.GetFractionString());
        Console.WriteLine(frac1.GetDeciamlValue());

        Fraction frac2 = new Fraction(5);
        Console.WriteLine(frac2.GetFractionString());
        Console.WriteLine(frac2.GetDeciamlValue());

        Fraction frac3 = new Fraction(3, 4);
        Console.WriteLine(frac3.GetFractionString());
        Console.WriteLine(frac3.GetDeciamlValue());

        Fraction frac4 = new Fraction(1, 3);
        Console.WriteLine(frac4.GetFractionString());
        Console.WriteLine(frac4.GetDeciamlValue());
        

        Fraction frac5 = new Fraction();
        Random random = new Random();
        for (int i = 0; i < 20; i++)
        {
            int topNum = random.Next(1, 11);
            int bottomNum = random.Next(1,11);
            frac5.SetTop(topNum);
            frac5.SetBottom(bottomNum);
            Console.Write($"Fraction {i + 1}: ");
            Console.Write($"string: {frac5.GetFractionString()} ");
            Console.WriteLine($"Decimal: {frac5.GetDeciamlValue()}");
        }

    }
}