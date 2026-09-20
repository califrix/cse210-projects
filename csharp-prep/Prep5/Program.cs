using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string username = PromptUserName();
        int usernum = PromptUserNumber();
        int squared = SquareNumber(usernum);

        int birthyear;
        PromptUserBirhtYear(out birthyear);

        DisplayResult(username, squared, birthyear);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Enter your Favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static void PromptUserBirhtYear(out int year)
    {
        Console.Write("What is your birth year:");
        year = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        int square = number * number;

        return square;
    }

    static void DisplayResult(string name, int square, int year)
    {
        Console.WriteLine($"{name}, The square of your number is {square}.");
        Console.WriteLine($"{name}, you will turn {2026 - year} years old this year.");
    }

}