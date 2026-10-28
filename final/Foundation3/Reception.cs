using System;

public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string desciption, string date, string time, Address address, string rsvpEmail) : base(title, desciption, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return base.GetStandardDetails() + $"Event Type: Reception\nRSVP Email: {_rsvpEmail}";
    }

    public override string GetShortDescription()
    {
        return $"Reception | {base.GetShortDescription().Replace("Event | ", "")}";
    }
}