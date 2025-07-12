using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your Grade Percentage? ");
        string gradePercentage = Console.ReadLine();
        int intPercentage = int.Parse(gradePercentage);

        string letter = "";

        if (intPercentage >= 90)
        {
            letter = "A";
        }
        else if (intPercentage >= 80)
        {
            letter = "B";
        }
        else if (intPercentage >= 70)
        {
            letter = "C";
        }
        else if (intPercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (intPercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("You can Improve!");
        }

    }
}