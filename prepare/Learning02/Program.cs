using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startDate = "2019";
        job1._endDate = "2022";

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startDate = "2022";
        job2._endDate = "2023";

        job1.Display();
        job2.Display();

        Resume myResume = new Resume();
        myResume._personName = "Allison Rose";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}