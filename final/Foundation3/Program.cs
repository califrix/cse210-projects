using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address(
            "100 University Avenue", "Rexburg", "ID",
            "USA", "83440");

        Address receptionAddress = new Address(
            "200 Main Street", "Idaho Falls", "ID",
            "USA", "83402");

        Address outdoorAddress = new Address(
            "300 Park Avenue", "Rexburg", "ID",
            "USA", "83440");

        Lecture lecture = new Lecture(
            "Technology and the Future",
            "Learn about emerging technology and innovation.",
            "November 15, 2026",
            "2:00 PM",
            lectureAddress,
            "Dr. Sarah Johnson",
            150);

        Reception reception = new Reception(
            "Annual Networking Reception",
            "Meet professionals and build new connections.",
            "November 20, 2026",
            "6:00 PM",
            receptionAddress,
            "rsvp@example.com");

        OutdoorGathering outdoor = new OutdoorGathering(
            "Community Park Festival",
            "Enjoy games, food, and activities with the community.",
            "November 22, 2026",
            "12:00 PM",
            outdoorAddress,
            "Sunny with a high of 65 degrees.");

        List<Event> events = new List<Event>
        {
            lecture,
            reception,
            outdoor
        };

        foreach (Event currentEvent in events)
        {
            Console.WriteLine("==================================");
            Console.WriteLine("STANDARD DETAILS");
            Console.WriteLine("==================================");
            Console.WriteLine(currentEvent.GetStandardDetails());

            Console.WriteLine("\n==================================");
            Console.WriteLine("FULL DETAILS");
            Console.WriteLine("==================================");
            Console.WriteLine(currentEvent.GetFullDetails());

            Console.WriteLine("\n==================================");
            Console.WriteLine("SHORT DESCRIPTION");
            Console.WriteLine("==================================");
            Console.WriteLine(currentEvent.GetShortDescription());

            Console.WriteLine("\n");
        }
    }
}
