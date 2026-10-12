
using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "4")
        {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();

            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;

                case "2":
                    activity = new ReflectionActivity();
                    break;

                case "3":
                    activity = new ListingActivity();
                    break;

                case "4":
                    Console.WriteLine("Thank you for using the program!");
                    break;

                default:
                    Console.WriteLine("Please select a valid option.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    break;
            }

            if (activity != null)
            {
                activity.Run();

                Console.WriteLine();
                Console.WriteLine("Press Enter to return to the menu.");
                Console.ReadLine();
            }
        }
    }
}
