using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Piano Teacher";
        job1._company = "Greatest Music School";
        job1._startYear = 2016;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Microsoft";
        job2._startYear = 2023;
        job2._endYear = 2025;

        Resume myResume = new Resume();
        myResume._name = "Marvin Galvez";

        myResume._jobsList.Add(job1);
        myResume._jobsList.Add(job2);

        myResume.Display();
    }
}