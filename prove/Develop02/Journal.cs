using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

public class Journal
{
    private List<Entry> entries = new List<Entry>();

    private List<string> prompts = new List<string>
    {"Who was the most interesting person I interacted with today?",
     "What was the best part of my day?",
     "How did I see the hand of the Lord in my life today?",
     "What was the strongest emotion I felt today?",
     "If I had one thing I could do over today, what would it be?"
    };

    public void AddEntry()
    {
        Random rnd = new Random();

        int index = rnd.Next(prompts.Count);
        string prompt = prompts[index];

        Console.Write($"Prompt: {prompt}\n>");
        
        string response = Console.ReadLine();

        string date = DateTime.Now.ToShortDateString();

        Entry newEntry = new Entry(date, prompt, response);

        entries.Add(newEntry);
    }

    public void Display()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("Your Journal Entry is empty.");
        }
        else
        {
            foreach (Entry entry in entries)
            {
                entry.Display();
            }
        }
    }

    public void Save(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
    }

    public void Load(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File Does not exist");
            return;
        }

        entries.Clear();

        string[] lines = File.ReadAllLines(filename);

        foreach(string line in lines)
        {
            string[] parts = line.Split('|');

            if (parts.Length >= 3)
            {
                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];

                Entry entry = new Entry(date, prompt, response);

                entries.Add(entry);
            }
        }
        Console.WriteLine("File Loaded Succesfully");
    }

}