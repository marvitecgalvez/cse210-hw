using System;

public class Resume
{
    public string _name;

    public List<Job> _jobsList = new List<Job>();

    public void Jobs()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job joby in _jobsList)
        {
            joby.DisplayJobDetails();
        }
    }
    
}