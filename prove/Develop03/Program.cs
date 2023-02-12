using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("D+C", 90, 24);
        string verse = "Search diligently, pray always, and be believing, and all things shall work together for your good.";
        Scripture scripture = new Scripture(reference, verse);
        var input = "";
       while (true){
            Console.WriteLine("Welcome to the memoriser app! To play simply hit enter. When you want to quit, type 'Quit'");
            Console.WriteLine(scripture.Display());
            input = Console.ReadLine();
            
            if (input == "Quit"|| input == "quit"){
                break;
            }
            if (scripture.IsCompletelyHidden()){
                break;
            }
            scripture.HideWords();

            

       }

    }
}