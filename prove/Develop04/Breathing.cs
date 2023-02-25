
public class Breathing : Activity{
    public Breathing() : base(){
        _name = "Breathing";
        _duration = 0;
        _description = "The breathing activity provides a guided breathing exercise"+ "\n" + "which allows you to slow your heart rate and clear your mind!";
    }

    public void Breathe()
    {
     for(int i = 5; i >= 0; i--)
       {
        Console.Write($"\rBreathe in... {i}");
        Thread.Sleep(1200);
       }
        Console.WriteLine(""); 
        
        for(int i = 5; i >= 0; i--)
       {
        Console.Write($"\rBreathe out... {i}");
        Thread.Sleep(1200);
       }
        Console.WriteLine("");
    }


    public void RunActivity()
    {
        GetDuration(_duration);
        DateTime currentTime = DateTime.Now;
        while(currentTime < _endTime)
        {
            Breathe();
            currentTime = DateTime.Now; 
            Console.WriteLine("");
        }
    }
}


