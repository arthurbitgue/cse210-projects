using System;

public class Job
{
    public string _jobTitle;
    public string _company;
    public string _startDate;
    public string _endDate;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startDate}-{_endDate}");
    }
}