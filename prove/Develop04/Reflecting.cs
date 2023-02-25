public class Reflecting : Activity{
   
    public Reflecting() : base(){
        _name = "Reflecting";
        _duration = 0;
        _description = "The reflecting activity will give you a prompt to consider,"+"\n"+ "you will then be given the opportunity to respond to some questions"+"\n"+"that will help you to reflect in the prompt.";
        
    }

    public string GetRandomPrompt()
    {
        List<string> prompts = new List<string>()
        {
            "Think of a time when you last overcame a temptation.",
            "Think of a time when you did something you didnt want to do.",
            "Think of a time when you served somebody.",
        };
        Random random = new Random();
        int index = random.Next(prompts.Count);
        string randPrompt = prompts[index];
        prompts.Remove(randPrompt);
        return randPrompt;
        }

    public void DisplayRandomPrompt(){
        string randPrompt = GetRandomPrompt();
        Console.WriteLine(randPrompt);
    }
    public string GetRandomQuestion()
    {
        List<string> questions = new List<string>()
        {
            "How did the end result make you feel?",
            "What helped you to succeed or even start?",
            "What can you do to be more successful next time?",
            "What did this experience teach you about yourself?",
            "How does this experience draw you closer to Christ?"
        };
        Random random = new Random();
        int index = random.Next(questions.Count);
        string randQuest = questions[index];
        questions.Remove(randQuest);
        return randQuest;
        }

    public void DisplayRandomQuestion(){
        string randQuest = GetRandomQuestion();
        Console.WriteLine(randQuest);
        }

    public void  RunActivity(){
        Console.WriteLine("Consider the following prompt" + "\n" + "and press enter once you have given yourself enough time to consider:");
        Console.WriteLine("");

        DisplayRandomPrompt();
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Now that you have an experience in mind, here are some questions to help you reflect on your experience: ");
        Console.WriteLine("");
        Console.Clear();

        for (int i = 5; i > 0; i--){
            Console.Write($"Delivering questions in {i} seconds.");
            Thread.Sleep(1000); 
            Console.Clear();   
            }

        Console.Clear();

        GetDuration(_duration);
        DateTime currentTime = DateTime.Now;
        while(currentTime < _endTime)
        {
            Console.Write(">");
            DisplayRandomQuestion();
            GetSpinner();
            currentTime = DateTime.Now;
            Console.WriteLine("");
        }
                
    }
}
