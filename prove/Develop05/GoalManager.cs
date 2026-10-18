using System.Collections.Generic;
using System.IO;


public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public int GetScore()
    {
        return _score;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailedString()}");
        }
    }

    public void RecordGoalEvent(int index)
    {
        if (index < 0 || index >= _goals.Count)
        {
            Console.WriteLine("Invalid goal number.");
            return;
        }

        int earned = _goals[index].RecordEvent();
        _score += earned;

        Console.WriteLine($"You earned {earned} points!");
        Console.WriteLine($"Total score: {_score}");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine($"Score~{_score}");

            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.SaveString());
            }
        }

        Console.WriteLine("Goals saved successfully!");
    }

    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("Save file not found.");
            return;
        }

        List<Goal> loadedGoals = new List<Goal>();
        int loadedScore = 0;

        foreach (string line in File.ReadAllLines(filename))
        {
            string[] parts = line.Split('~');

            if (parts[0] == "Score")
            {
                loadedScore = int.Parse(parts[1]);
                continue;
            }

            string name = parts[1];
            string description = parts[2];

            int points = int.Parse(parts[3]);

            switch (parts[0])
            {
                case "Simple":
                    SimpleGoal simple = new SimpleGoal(
                        name, description, points);

                    if (bool.Parse(parts[4]))
                        simple.RecordEvent();

                    loadedGoals.Add(simple);
                    break;

                case "Eternal":
                    loadedGoals.Add(
                        new EternalGoal(name, description, points));
                    break;

                case "Checklist":
                    int completed = int.Parse(parts[4]);
                    int target = int.Parse(parts[5]);
                    int bonus = int.Parse(parts[6]);

                    ChecklistGoals checklist = new ChecklistGoals(
                        name, description, points, target, bonus);

                    for (int i = 0; i < completed; i++)
                        checklist.RecordEvent();

                    loadedGoals.Add(checklist);
                    break;
            }
        }

        _goals = loadedGoals;
        _score = loadedScore;

        Console.WriteLine("Goals loaded successfully!");
    }
}