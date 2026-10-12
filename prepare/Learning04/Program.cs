using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Sameuel Bennett", "Multiplication");

        Console.WriteLine(assignment.GetSummary());



        MathAssignment mathAssignment = new MathAssignment("Samuel Bennett", "Multiplication", "7.3", "8-19");

        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        
        
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");

        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}
