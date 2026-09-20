using System;

class Program
{
    static void Main(string[] args)
    {
        
        int perc = 60;

        if (perc < 60)
        {
            Console.WriteLine("Your grade is a F");
        }
        else if (perc >= 90)
        {
            Console.WriteLine("Your grade is a A");
        }
        else if (perc >= 80)
        {
            Console.WriteLine("Your grade is a B");
        }
        else if (perc >= 70)
        {
            Console.WriteLine("Your grade is a C");
        }
        else if (perc >= 60)
        {
            Console.WriteLine("Your grade is a D");
        }

        

    }
}