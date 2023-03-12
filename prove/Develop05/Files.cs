using System.IO;

public class GoalFiles
{
    private List<Goal> _goals = new List<Goal>();
    private int _points = 0;

    public GoalFiles()
    {
        _points = 0;
        _goals = new List<Goal>();
    }

    public void Save(List<Goal> goals, int points)
    {
        Console.WriteLine("Please name your file:");
        string fileName = Console.ReadLine();
        using (StreamWriter file = new StreamWriter(fileName))
        {
            file.WriteLine(points);
            foreach (Goal line in goals)
            {
                file.WriteLine(line.DisplayGoalString());
            }
        }
    }

    public void Load()
    {
        Console.WriteLine("Enter file name:");
        string fileName = Console.ReadLine();
        String line;
        try
        {
            using (StreamReader file = new StreamReader(fileName))
            {
                line = file.ReadLine();
                _points = int.Parse(line);
                line = file.ReadLine();
                while (line != null)
                {
                    string[] goalLines = line.Split("|");
                    string goalType = goalLines[0];
                    if(goalType == "SimpleGoal")
                    {
                        Simple goal = new Simple(goalLines[1], goalLines[2],int.Parse(goalLines[3]), bool.Parse(goalLines[4]));
                        _goals.Add(goal);
                    }
                    if(goalType == "EternalGoal")
                    {
                        Eternal goal = new Eternal(goalLines[1], goalLines[2],int.Parse(goalLines[3]), bool.Parse(goalLines[4]));
                        _goals.Add(goal);
                    }
                     if(goalType == "ChecklistGoal")
                     {
                        Checklist goal = new Checklist(goalLines[1], goalLines[2],int.Parse(goalLines[3]),bool.Parse(goalLines[4]), int.Parse(goalLines[5]),int.Parse(goalLines[6]),int.Parse(goalLines[7]));
                        _goals.Add(goal);
                    }
                    line = file.ReadLine();
                };
            }

        }
        catch (Exception error)
        {
            Console.WriteLine("Exception:" + error.Message);
        }
    }
    public List<Goal> GetGoals()
    {
        return _goals;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void GetRecordEvent(List<Goal> goals){
        Console.WriteLine("The goals are: ");
                int x = 0;
                foreach(Goal goal in goals)
                {
                    x++;
                    goal.DisplayGoal(x);
                }
                Console.Write("Which goal would you like to record? ");
                int input = int.Parse(Console.ReadLine());
                Goal selectedGoal = goals[input-1];
                selectedGoal.RecordEvent();
                _points = GetPoints() + selectedGoal.GetPoints();
                Console.WriteLine($"Congratulation you have earned {selectedGoal.GetPoints()}");
                Console.WriteLine($"You now have {_points}");
                Console.WriteLine("");
    }
}