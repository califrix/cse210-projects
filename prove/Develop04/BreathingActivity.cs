
using System;
using System.Diagnostics;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            "Breathing Activity",
            "This activity will help you relax by walking you through " +
            "breathing in and out slowly. Clear your mind and focus on " +
            "your breathing.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();

        Stopwatch stopwatch = Stopwatch.StartNew();

        while (stopwatch.Elapsed.TotalSeconds < Duration)
        {
            double remaining = Duration - stopwatch.Elapsed.TotalSeconds;

            if (remaining <= 0)
            {
                break;
            }

            int breathDuration = Math.Min(4, (int)Math.Ceiling(remaining));

            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(breathDuration);

            remaining = Duration - stopwatch.Elapsed.TotalSeconds;

            if (remaining <= 0)
            {
                break;
            }

            breathDuration = Math.Min(4, (int)Math.Ceiling(remaining));

            Console.WriteLine();
            Console.Write("Breathe out...");
            ShowCountDown(breathDuration);
        }

        stopwatch.Stop();
        DisplayEndingMessage();
    }
}
