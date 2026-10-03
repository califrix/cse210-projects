using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureRef refernce = new ScriptureRef("D&C", 6, 35, 36);

        string text = "Behold, I do not condemn you; go your ways and sin no more; perform with soberness the work which I have commanded you. Look unto me in every thought; doubt not, fear not.";

        Scripture scripture = new Scripture(refernce, text);

        while (!scripture.IscompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetText());

            Console.Write("\nPress Enter to continue or type 'quit' to finish: ");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideWords(3);

        }
    }
}