using System;

public class Activity{
    protected string _name;
    protected int _duration;
    protected string _description;
    protected DateTime _endTime;

   
    public void GetSpinner(){
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);
        while (DateTime.Now < endTime){
            foreach (string s in animationStrings)
            {
            Console.Write(s);
            Thread.Sleep(750);
            Console.Write("\b");
            }   
        }
        
        

    }

    public void GetDuration(int duration){
        DateTime startTime = DateTime.Now;
        _endTime = startTime.AddSeconds(duration);


    }

    public void StartMessage()
   {    Console.Write($"Loading {_name} activity...");
        GetSpinner();
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} activity.");
        Console.WriteLine($"{_description}");
        Console.WriteLine("How long would you like to participate? (in seconds)");
        _duration = int.Parse(Console.ReadLine());
        Console.Write("Loading...");
        GetSpinner();
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Thread.Sleep(1000);
        Console.Clear();
   }

   public void EndMessage()
   {
    Console.WriteLine($"You have completed the {_name} acitivty!");
    Console.WriteLine($"We hope this was a relaxing and pleasant experience for you!");
   }




}