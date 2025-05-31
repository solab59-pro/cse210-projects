using System;

public class Job
{// this is the attributes or state of our job description
    public string _companyName;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;


    public void Display()
    {//this is the file method used to display the job details
        Console.WriteLine($"{_companyName} ({_jobTitle}) {_startYear}-{_endYear}");
    }
}
