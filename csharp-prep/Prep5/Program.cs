using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }



    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to my program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name:");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number?:");
        int favNum = int.Parse(Console.ReadLine());

        return favNum;
    }

    static int SquareNumber(int favNum)
    {
        int square = favNum * favNum;
        return square;     
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
    }

}