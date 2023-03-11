public class Checklist : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public Checklist() : base ()
    {
        _isComplete = false;
        _targetCount = 0;
        _currentCount = 0;
        _bonusPoints = 0;
    }

    public Checklist(string name, string description, int points, bool isComplete, int currentCount, int targetCount, int bonusPoints)
    {
        _name = name;
        _desc = description;
        _points = points;
        _isComplete = isComplete;
        _targetCount = targetCount;
        _currentCount = currentCount;
        _bonusPoints = bonusPoints;
    }

    public void GoalBonus()
    {
        Console.WriteLine("How many times would you like to complete this goal?");
        _targetCount  = int.Parse(Console.ReadLine());
        Console.Write("How many bonus points is this worth?");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

    public override void ShowGoal(int goalNumber)
    {
        string checkBox = "[]";
        if (_isComplete)
        checkBox = "[x]";
        Console.WriteLine($"{goalNumber}. {checkBox} {_name} ({_desc}) >>> Progress {_currentCount}/{_targetCount}");
    }

    public override void RecordEvent()
    {
        _currentCount ++;
        if (_currentCount == _targetCount){
            _isComplete = true;
        }
    }

        public override string DisplayGoal()
    {
        string goal = $"ChecklistGoal|{_name}|{_desc}|{_points}|{_isComplete}|{_currentCount}/{_targetCount}|{_bonusPoints}";
        return goal;
    }



}

