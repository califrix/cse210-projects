using System;

public class ChecklistGoals : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoals(string name, string descirption, int points, int target, int bonus) : base(name, descirption, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override int RecordEvent()
    {
        if (IsComplete())
            return 0;

        _amountCompleted++;
        int earned = GetPoints();

        if (IsComplete())
            earned += _bonus;

        return earned;
    }

    public override string GetDetailedString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";

        return $"{status} {GetName()} ({GetDescription()}) -- " +
               $"Completed {_amountCompleted}/{_target} times";
    }

    public override string SaveString()
    {
       return $"Checklist~{GetName()}~{GetDescription()}~{GetPoints()}~{_amountCompleted}~{_target}~{_bonus}";
    }
}