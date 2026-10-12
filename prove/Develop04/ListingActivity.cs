
using System;
using System.Collections.Generic;
using System.Diagnostics;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _items;
    private Random _random;

    public ListingActivity()
        : base(
            "Listing Activity",
            "This activity will help you reflect on the good things in " +
            "your life by having you list as many things as you can " +
            "in a certain area.")
    {
        _random = new Random();
        _items = new List<string>();

        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public override void Run()
    {
        DisplayStartingMessage();

        string prompt = _prompts[_random.Next(_prompts.Count)];

        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();

        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Start listing items. Press Enter after each item.");

        _items.Clear();

        Stopwatch stopwatch = Stopwatch.StartNew();

        while (stopwatch.Elapsed.TotalSeconds < Duration)
        {
            double remaining = Duration - stopwatch.Elapsed.TotalSeconds;

            Console.WriteLine(
                $"Time remaining: {Math.Ceiling(remaining)} seconds");
            Console.Write("Item: ");

            string item = Console.ReadLine();

            if (stopwatch.Elapsed.TotalSeconds >= Duration)
            {
                break;
            }

            if (!string.IsNullOrWhiteSpace(item))
            {
                _items.Add(item.Trim());
            }
        }

        stopwatch.Stop();

        Console.WriteLine();
        Console.WriteLine($"You listed {_items.Count} items.");

        DisplayEndingMessage();
    }
}
