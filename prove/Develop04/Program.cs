

class Program
{
    static void Main(string[] args)
    {
        int quit = 0;

        while (quit != 4){
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Oasis!");
            Console.WriteLine("Please select from our menu of Mindfulness activities!");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Quit");
            quit = int.Parse(Console.ReadLine());
            Console.Clear();

            if (quit == 1)
            {
                Breathing breathing = new Breathing();
                breathing.StartMessage();
                breathing.RunActivity();
                breathing.EndMessage();
            }

            else if (quit == 2)
            {
                Listing listing = new Listing();
                listing.StartMessage();
                listing.RunActivity();
                listing.EndMessage();
            } 

            else if (quit == 3)
            {
                Reflecting reflecting = new Reflecting();
                reflecting.StartMessage();
                reflecting.RunActivity();
                reflecting.EndMessage();
            }

            else
            {
                Console.WriteLine("Thank you for visiting the Mindfulness Oasis!");
                break;
            }
        }
    }
}