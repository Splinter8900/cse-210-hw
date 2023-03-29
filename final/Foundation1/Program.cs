using System;

class Program
{
    static void Main(string[] args)
    {   
        List<Video> videos = new List<Video>();

        //Creating Comments
        //video 1
        Comment comment1 = new Comment();
        comment1._name = "Steve";
        comment1._comment = "This video was hilarious!";

        Comment comment2 = new Comment();
        comment2._name = "John";
        comment2._comment = "Super funny video!";

        Comment comment3 = new Comment();
        comment3._name = "Bob";
        comment3._comment = "I would love to see more";

        // video2
        Comment comment4 = new Comment();
        comment4._name = "Savannah";
        comment4._comment = "asdfasdf";

        Comment comment5 = new Comment();
        comment5._name = "Emily";
        comment5._comment = "asdfasdf";

        Comment comment6 = new Comment();
        comment6._name = "Todd";
        comment6._comment = "asddsafafds";

        //video3

        Comment comment7 = new Comment();
        comment7._name = "Denon";
        comment7._comment = "asdfasdfasd";

        Comment comment8 = new Comment();
        comment8._name = "Spencer";
        comment8._comment = "adsfsadfsad";

        Comment comment9 = new Comment();
        comment9._name = "Nathan";
        comment9._comment = "asdfasdfasdf";

        //Creating Vidoes

        Video video1 = new Video();
        video1._title = "Epic Fails";
        video1._author = "Bojangle Tim";
        video1._length = 130;
        videos.Add(video1);


        Video video2 = new Video();
        video1._title = "Top 10 New Games";
        video1._author = "GamerScores";
        video1._length = 45;
        videos.Add(video2);


        Video video3 = new Video();
        video1._title = "How to Program With Classes";
        video1._author = "Brother Poulson";
        video1._length = 642;
        videos.Add(video3);

        foreach(Video video in videos)
        {
            video.Display();
        }

    }   
}