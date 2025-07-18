using System;

public class Journal
{
    public List<Entry> _entriesList = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entriesList.Add(newEntry);
    }

    public void SaveToFile(string fileForSave)
    {
        using (StreamWriter outputFile = new StreamWriter(fileForSave))
        {
            foreach (Entry i in _entriesList)
            {
                outputFile.WriteLine($"{i._date}|{i._Prompt}|{i._userEntry}");
            }
        }

        Console.WriteLine("Journal Saved!");
    }

    public void LoadFromFile(string fileForLoad)
    {
        ////// Comprobar que existe el archivo
        if (!File.Exists(fileForLoad))
        {
            Console.WriteLine("File not found.");
            return;
        }

        //////////// crear lista y Cargar las entradas 
        List<Entry> temporalEntries = new List<Entry>();
        string[] journalLines = File.ReadAllLines(fileForLoad);
        foreach (string i in journalLines)
        {
            string[] parts = i.Split('|');
            if (parts.Length == 3)
            {
                Entry newReg = new Entry
                {
                    _date = parts[0],
                    _Prompt = parts[1],
                    _userEntry = parts[2]
                };
                temporalEntries.Add(newReg);
            }
        }

        _entriesList = temporalEntries;
        Console.WriteLine("Journal Loaded!");
    }



    public void DisplayAll()
    {
        if (_entriesList.Count == 0)
        {
            Console.WriteLine("Your Journal is empty.");
            return;
        }
        else
        {
            Console.WriteLine("Your Journal Entries:");
            foreach (Entry i in _entriesList)
            {
                i.Display();
            }
            Console.WriteLine("The End");
        }

    }
}