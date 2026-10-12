
using System;
using System.Threading;

public abstract class Activity
{
    private string _activityName;
    private string _description;
    private int _duration;

    protected int Duration
    {
        get { return _duration; }
    }

    protected Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
        _duration = 0;
    }

    protected void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");

        while (!int.TryParse(Console.ReadLine(), out _duration)
               || _duration <= 0)
        {
            Console.Write("Please enter a positive number of seconds: ");
        }

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Good job!");
        Console.WriteLine("You have done a great job completing this activity.");
        ShowSpinner(2);

        Console.WriteLine();
        Console.WriteLine(
            $"You have completed the {_activityName} for {_duration} seconds.");

        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        char[] spinner = { '|', '/', '-', '\\' };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int index = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[index % spinner.Length]);
            Thread.Sleep(250);
            Console.Write("\b");
            index++;
        }

        Console.Write(" \b");
    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public abstract void Run();
}
