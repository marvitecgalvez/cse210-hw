using System;

public class Entry
{
    public string _date;
    public string _Prompt;
    public string _userEntry;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - {_Prompt}");
        Console.WriteLine($"Entry: {_userEntry}");
    }
}