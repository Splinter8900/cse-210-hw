public class Simple : Goal
{
    public Simple(): base()
    {
        _isComplete = false;
    }

    public Simple(string name, string description, int points, bool isComplete)
    {
        _name = name;
        _desc = description;
        _points = points;
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override void ShowGoal(int goalNumber)
    {
        string checkBox = "[]";
        if (_isComplete)
        checkBox = "[x]";
        Console.WriteLine($"{goalNumber}. {checkBox} {_name} ({_desc})");
    }

    public override string DisplayGoal()
    {
        string goal = $"SimpleGoal|{_name}|{_desc}|{_points}|{_isComplete}";
        return goal;
    }

}