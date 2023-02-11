using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureCollection scriptures = new ScriptureCollection();
        Scripture scripture = scriptures.GetRandomScripture();
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