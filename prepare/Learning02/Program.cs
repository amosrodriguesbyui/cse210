using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();

        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Microsoft";

        Resume resume = new Resume();

        resume._name = "Amos Rodrigues";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.DisplayResumeDetails();
    }
}