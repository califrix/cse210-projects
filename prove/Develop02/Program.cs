using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        Journal journal = new Journal();
        Console.WriteLine("Weclome to the Journal Program");

        while(choice != 5)
        {
            Console.Write("\nPlease Select one of the following options:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do? ");
            choice = int.Parse(Console.ReadLine());

            if(choice == 1)
            {
               journal.AddEntry();
            }
            else if(choice == 2)
            {
                journal.Display();
            }
            else if(choice == 3)
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                
                journal.Load(filename);
            }
            else if(choice == 4)
            {
                Console.Write("Enter the Filename: ");
                string filename = Console.ReadLine();

                journal.Save(filename);
            }
        }
    }
}