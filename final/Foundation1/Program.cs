using System;

class Program
{
    static void Main(string[] args)
    {   
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Epic fails!", "Fail Army", 160);
        video1.AddComment("Steve", "This video was so funny!" );
        video1.AddComment("Thomas", "These videos always crack me up!");
        video1.AddComment("Sue", "I can't wait for the next one!");
        videos.Add(video1);

        Video video2 = new Video("Experiences", "Ludovico Einaudi ", 350);
        video2.AddComment("Emily", "I love Einaudi" );
        video2.AddComment("Denon", "His music is so relaxing!");
        video2.AddComment("Spencer", "I wish I was this good");
        videos.Add(video2);

        Video video3 = new Video("How to code with classes", "Brother Poulson", 578);
        video3.AddComment("Ben", "Super helpful info!" );
        video3.AddComment("Frank", "I like the way we can use code to do a lot!");
        video3.AddComment("Steve", "How do you use classes more efficiently?");
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("Title: {0}", video._title);
            Console.WriteLine("Author: {0}", video._author);
            Console.WriteLine("Length: {0} seconds", video._length);
            Console.WriteLine("Number of Comments: {0}", video.NumComment());
            Console.WriteLine("Comments:");
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine("{0}: {1}", comment._name, comment._comment);
            }
            Console.WriteLine();
        }

       

    }   
}