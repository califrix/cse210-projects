using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override int RecordEvent()
    {
        return GetPoints();
    }

    public override string GetDetailedString()
    {
        return $"[ ] {GetName()} ({GetDescription()})";
    }

    public override string SaveString()
    {
        return $"Eternal~{GetName()}~{GetDescription()}~{GetPoints()}";
    }   
}