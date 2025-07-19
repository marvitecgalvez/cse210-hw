using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator generator = new PromptGenerator();
        bool keepRunning = true;

        while (keepRunning)
        {
            Console.WriteLine("Welcome to the Journal Program!");
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
                    Console.Write("> ");
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
                    Console.Write("What is the filename to save to? ");
                    string saveFile = Console.ReadLine();
                    myJournal.SaveToFile(saveFile);
                    break;

                case "4":
                    Console.Write("What is the filename to load from? ");
                    string loadFile = Console.ReadLine();
                    myJournal.LoadFromFile(loadFile);
                    break;

                case "5":
                    keepRunning = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.\n");
                    break;
            }
        }
        Console.WriteLine("Goodbye!");

    }
}