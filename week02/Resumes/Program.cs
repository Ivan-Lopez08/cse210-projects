using System;

class Program
{
    static void Main(string[] args)
    {
        Resume myResume = new Resume();
        Job job1 = new Job();
        Job job2 = new Job();

        job1._company = "Invisible technologies";
        job1._jobTitle = "AI Trainer";
        job1._startYear = 2024;
        job1._endYear = 2025;

        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        myResume._name = "Ivan Lopez";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}