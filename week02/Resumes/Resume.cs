using System;

public class Resume
{// Resume has job description and a name is included.
// However our Job class has taken care of our job description
// So we only need to include our name in the resume
    public string _name;

    // Make sure to initialize your list to a new List before you use it.
    //Remember our Resume must include the jobs, so we bring the job here in our resume
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Notice the use of the custom data type "Job" in this loop
        foreach (Job job in _jobs)
        {
            // This calls the Display method on each job
            job.Display();
        }
    }
}