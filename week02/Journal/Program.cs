using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator generator = new PromptGenerator();
        bool turnOnOff = true;

        Console.WriteLine("Welcome to the Journal Program!");


        ////////// Usar turnOnOff para empezar, y detener el programa cuando sea falso
        while (turnOnOff)
        {

            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Exit");
            Console.Write("What would you like to do? ");

            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    string randomPrompt = generator.GetRandomPrompt();
                    Console.WriteLine(randomPrompt);
                    string entryText = Console.ReadLine();
                    string date = DateTime.Now.ToShortDateString();
                    Entry newEntry = new Entry
                    {
                        _date = date,
                        _Prompt = randomPrompt,
                        _userEntry = entryText
                    };
                    myJournal.AddEntry(newEntry);
                    Console.WriteLine("Entry saved!\n");
                    break;

                case "2":
                    myJournal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter the filename to save to? ");
                    string saveFile = Console.ReadLine();
                    myJournal.SaveToFile(saveFile);
                    break;

                case "4":
                    Console.Write("Enter the filename to load from? ");
                    string loadFile = Console.ReadLine();
                    myJournal.LoadFromFile(loadFile);
                    break;

                case "5":
                    turnOnOff = false;
                    break;

                default:
                    Console.WriteLine("Please enter a valid option.\n");
                    break;
            }
        }
        Console.WriteLine("See you Tomorrow!");

    }
}