using System;

class Entry
{
    public string Date;
    public string Prompt;
    public string Response;

    public Entry(string date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {Date} Prompt: {Prompt} {Response}");
        
    }
}
