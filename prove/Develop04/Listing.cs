public class Listing : Activity{

    public Listing () : base(){
        _name = "Listing";
        _duration = 0;
        _description = "The listing activity gives you an opportunity to express gratitude"+ "\n" + "by listing as many positives as you can about a prompted area of your life";
    }

    public string GetRandomPrompt()
    {
        List<string> prompts = new List<string>()
        {
            "When has God blessed your life today?",
            "What opportunities did you have to serve others?",
            "What are some attributes that you like about yourself?"
        };
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
        }

    public void DisplayRandomPrompt(){
        string randPrompt = GetRandomPrompt();
        Console.WriteLine(randPrompt);
    }
    
    public void RunActivity()
    {   
        int items = 0;
        GetDuration(_duration);
        DisplayRandomPrompt();
        DateTime currentTime = DateTime.Now;
        while(currentTime < _endTime)
        {   
            Console.Write(">");
            Console.ReadLine();
            items += 1;
            currentTime = DateTime.Now; 
            
        }
        Console.WriteLine($"You listed {items} items!");
    }
}
