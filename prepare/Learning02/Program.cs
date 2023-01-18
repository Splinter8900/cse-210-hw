using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Firefighter";
        job1._company = "FiresRUs";
        job1._startYear = 2009;
        job1._endYear = 2013;

        Job job2 = new Job();
        job2._jobTitle = "Chef";
        job2._company = "FoodsRUs";
        job2._startYear = 2013;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Ben Shurtz";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}