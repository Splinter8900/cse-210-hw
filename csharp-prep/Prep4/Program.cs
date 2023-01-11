using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Please enter a number. If you would like to quit, enter 0:");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

        Console.WriteLine($"The sum of number is: {sum}");

        float avg = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average of the list is: {avg}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The largest number is: {max}");
    }   

        
}