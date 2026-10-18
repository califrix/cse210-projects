public class Program
{
    public static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n=== Eternal Quest ===");
            Console.WriteLine($"Score: {manager.GetScore()}");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Record a goal event");
            Console.WriteLine("3. Display goals");
            Console.WriteLine("4. Save goals");
            Console.WriteLine("5. Load goals");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1":
                    CreateGoal(manager);
                    break;

                case "2":
                    manager.DisplayGoals();
                    Console.Write("Which goal did you accomplish? ");

                    int goalNumber = ReadInt();
                    manager.RecordGoalEvent(goalNumber - 1);
                    break;

                case "3":
                    manager.DisplayGoals();
                    break;

                case "4":
                    manager.SaveGoals("eternalquest.txt");
                    break;

                case "5":
                    manager.LoadGoals("eternalquest.txt");
                    break;

                case "6":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Please choose a valid option.");
                    break;
            }
        }

        Console.WriteLine("Keep working on your Eternal Quest!");
    }

    private static void CreateGoal(GoalManager manager)
    {
        Console.WriteLine("\nChoose a goal type:");
        Console.WriteLine("1. Simple goal");
        Console.WriteLine("2. Eternal goal");
        Console.WriteLine("3. Checklist goal");
        Console.Write("Choice: ");

        string type = Console.ReadLine() ?? "";

        Console.Write("Goal name: ");
        string name = Console.ReadLine() ?? "";

        Console.Write("Description: ");
        string description = Console.ReadLine() ?? "";

        Console.Write("Points: ");
        int points = ReadInt();

        switch (type)
        {
            case "1":
                manager.AddGoal(
                    new SimpleGoal(name, description, points));
                break;

            case "2":
                manager.AddGoal(
                    new EternalGoal(name, description, points));
                break;

            case "3":
                Console.Write("How many times must you complete it? ");
                int target = ReadInt();

                Console.Write("Bonus points for completion: ");
                int bonus = ReadInt();

                manager.AddGoal(
                    new ChecklistGoals(
                        name, description, points, target, bonus));
                break;

            default:
                Console.WriteLine("Invalid goal type. Goal not created.");
                return;
        }

        Console.WriteLine("Goal created successfully!");
    }

    private static int ReadInt()
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int value))
                return value;

            Console.Write("Please enter a whole number: ");
        }
    }
}