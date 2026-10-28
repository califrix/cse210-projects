using System;

public class Activity
{
    private DateTime _date;
    private int _length;

    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }

    public int GetLength()
    {
        return _length;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return (GetDistance() / _length) * 60;
    }

    public virtual double GetPace()
    {
        return _length / GetDistance();
    }

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} Activity ({_length} min) - Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.00} min per mile";
    }
}
