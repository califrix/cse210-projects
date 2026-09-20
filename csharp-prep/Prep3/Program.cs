using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int mNum = randomGenerator.Next(1, 101);
        int response = 0;

        while(response != mNum)
        {
            Console.Write("What is your guess?");
            response = int.Parse(Console.ReadLine());

            if (response < mNum)
            {
                Console.WriteLine("Higher");
            }
            else if (response > mNum)
            {
                Console.WriteLine("Lower");
            }
        }
        Console.WriteLine("You guessed it!");
    }
}