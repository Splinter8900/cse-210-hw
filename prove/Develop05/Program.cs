using System;

class Program
{
    static void Main(string[] args)
    {
        GoalFiles file = new GoalFiles();
        List<Goal> goals = new List<Goal>();
        int points = 0;
        int quit = 0;
        int choice = 0;
        while (quit != 6)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Eternal Quest");
            Console.WriteLine($"You have {points} points.");
            Console.WriteLine(" ");
            Console.WriteLine("Here are your menu options");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.WriteLine("Please select an option:");
            quit = int.Parse(Console.ReadLine());
            Console.Clear();

            if (quit == 1)
            {        
                Console.WriteLine("Please select a goal type from the following:");
                Console.WriteLine("1. Simple Goal - A goal that is finished after completing it one time.");
                Console.WriteLine("2. Eternal Goal - A goal that you never really finish but you can continually get points from, for eternity!");
                Console.WriteLine("3. Checklist Goal- This is a goal where you specify the number of time you would like to complete it."+"\n" + "You earn points for each completion as well as bonus points for hitting your total! ");          
                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Simple simple = new Simple();
                    simple.GoalName();
                    simple.GoalDesc();
                    simple.GoalPoints();
                    goals.Add(simple);
                }

                if (choice == 2)
                {
                  Eternal eternal = new Eternal();
                    eternal.GoalName();
                    eternal.GoalDesc();
                    eternal.GoalPoints();
                    goals.Add(eternal);  
                }
                if (choice == 3)
                {
                    Checklist checklist = new Checklist();
                    checklist.GoalName();
                    checklist.GoalDesc();
                    checklist.GoalPoints();
                    checklist.GoalBonus(); 
                    goals.Add(checklist);
                }
            }

            else if (quit == 2)
            {
                int x = 0;
                foreach (Goal goal in goals)
                {
                    x++;
                    goal.ShowGoal(x);
                }    
            }

            else if (quit == 3)
            {
                file.Save(goals, points);
            }

            else if (quit == 4)
            {
                file.Load();
                goals = file.GetGoals();
                points = file.GetPoints();
            }

            else if (quit == 5)
            {
                file.GetRecordEvent(goals);
                points = file.GetPoints();
            }

            else
            {
              Console.WriteLine("Thanks fo setting goals with us today!");
              break;  
            }
        }
    }
}