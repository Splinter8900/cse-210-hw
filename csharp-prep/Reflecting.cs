public class Reflecting : Activity{
    private string _prompt;
    private string _question;

    public Reflecting() : base(){
        _name = "Reflecting";
        _duration = 0;
        _description = "The reflecting activity will give you a prompt to consider, you will then be given the opportunity to respond to some questions that will help you to reflect in the prompt";
        _prompt = "";
        _question = "";
    }

    public string GetRandomPrompt()
    {
        List<string> prompts = new List<string>()
        {
            "Think of a time when you last overcame a temptation.",
            "Think of a time when you did something you didnt want to do.",
            "Think of a  time when you served somebody",
        };
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
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
            "What can you do to be more successful next time?"
        };
        Random random = new Random();
        int index = random.Next(questions.Count);
        return questions[index];
        }

    public void DisplayRandomQuestion(){
        string randQuest = GetRandomQuestion();
        Console.WriteLine(randQuest);
        }

    public void  RunActivity(){
        Console.WriteLine("Consider the following prompt and press enter once you have given yourself enough time to consider:");
        Console.WriteLine("");
        DisplayRandomPrompt();
        Console.ReadLine();



        
    }
}
