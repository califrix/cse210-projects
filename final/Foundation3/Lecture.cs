using System;
using System.ComponentModel;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string desciption, string date, string time, Address address, string speaker, int capacity) : base(title, desciption, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return base.GetStandardDetails() + $"Event Type: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity} people";
    }

    public override string GetShortDescription()
    {
        return $"Lecture | {base.GetShortDescription().Replace("Event | ", "")}";
    }
}