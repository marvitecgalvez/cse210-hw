using System;
using System.Diagnostics.Tracing;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> allNumbers = new List<int>();

        int input = -1;

        while (input != 0)
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                allNumbers.Add(input);
            }
        }

        /////////////// sum
        int suma = 0;
        foreach (int i in allNumbers)
        {
            suma += i;
        }

        Console.WriteLine($"The sum is: {suma}");

        ////////// average
        float average = ((float)suma) / allNumbers.Count;
        Console.WriteLine($"The average is: {average}");

        ////////// largest
        int max = allNumbers[0];

        foreach (int i in allNumbers)
        {
            if (i > max)
            {
                max = i;
            }
        }

        Console.WriteLine($"The largest number is: {max}");
    }
}