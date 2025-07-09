using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your Grade Percentage? ");
        string gradePercentage = Console.ReadLine();
        int intPercentage = int.Parse(gradePercentage);

        string calification = "";

        if (intPercentage >= 90)
        {
            calification = "A";
        }
        else if (intPercentage >= 80)
        {
            calification = "B";
        }
        else if (intPercentage >= 70)
        {
            calification = "C";
        }
        else if (intPercentage >= 60)
        {
            calification = "D";
        }
        else
        {
            calification = "F";
        }

        Console.WriteLine($"Your grade is: {calification}");

    }
}