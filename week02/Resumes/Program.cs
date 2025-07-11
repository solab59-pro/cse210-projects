using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._companyName = "Microsoft"; //remember the ._companyName access it from the Job  and 
        //then it assigns the variable to Microsoft to the companyName
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2024;
        job1._endYear = 2026;

        Job job2 = new Job();
        job2._companyName = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2012;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "John Solomon Ekaette";

        myResume._jobs.Add(job1); //add the job to the list
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}