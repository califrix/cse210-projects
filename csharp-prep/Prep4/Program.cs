using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int response = -1;

        while (response != 0)
        {
            Console.Write("Enter Number: ");
            response = int.Parse(Console.ReadLine());
            if (response != 0)
            {
                numbers.Add(response);
            }

        }
        Console.WriteLine($"The sum is: {numbers.Sum()}");
        Console.WriteLine($"The Average is: {numbers.Average()}");
        Console.WriteLine($"The Largest number is: {numbers.Max()}");
        
    }
}