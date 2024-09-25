using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Beneva";
        job1._jobTitle = "Web Developper";
        job1._startYear = 2025 ;
        job1._endYear = 2028;

        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Web Developper";
        job2._startYear = 2028 ;
        job2._endYear = 2035;

        Resume myResume = new Resume();
        myResume._userName = "Greice";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();

    }
}