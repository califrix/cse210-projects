using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string descirption, int points) : base(name, descirption, points)
    {
        _isComplete = false;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override int RecordEvent()
    {
        if (_isComplete)
            return 0;
        

        _isComplete = true;
        return GetPoints();
    }

    public override string GetDetailedString()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return $"{status} {GetName()} ({GetDescription()})";
    }

    public override string SaveString()
    {
        return $"Simple~{GetName()}~{GetDescription()}~{GetPoints()}~{_isComplete}";
    }
}