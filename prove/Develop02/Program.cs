using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        while (true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Load the journal from a file");
            Console.WriteLine("4. Save the journal to a file");
            Console.WriteLine("5. Exit");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Entry newEntry = new Entry();
                newEntry._prompt = GetRandomPrompt();
                Console.WriteLine(newEntry._prompt);
                newEntry._response = Console.ReadLine();
                DateTime theCurrentTime = DateTime.Now;
                newEntry._date = theCurrentTime.ToShortDateString();
                journal._entries.Add(newEntry);
            }
            else if (choice == 2)
            {
                journal.Display();
            }
            else if (choice == 3)
            {
                Console.Write("Enter the filename: ");
                journal._filename = Console.ReadLine();
                journal.LoadFile();
            }
            else if (choice == 4)
            {
                Console.Write("Enter the filename: ");
                journal._filename = Console.ReadLine();
                journal.SaveFile();
            }
            else if (choice == 5)
            {
                break;
            }
        }
        static string GetRandomPrompt()
    {
        List<string> prompts = new List<string>()
        {
            "What is your favorite thing you did today?",
            "What Blessings have you seen from the Lord today?",
            "What did you learn in your scripture study?",
            "Describe a time when you felt the spirit?",
            "Who were you able to serve today and what did you do?",
            

        };
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
    }


    }