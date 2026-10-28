using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running(
            new DateTime(2026, 11, 3), 30, 3.0);

        Cycling cycling = new Cycling(
            new DateTime(2026, 11, 4), 45, 15.0);

        Swimming swimming = new Swimming(
            new DateTime(2026, 11, 5), 30, 20);

        List<Activity> activities = new List<Activity>
        {
            running,
            cycling,
            swimming
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
