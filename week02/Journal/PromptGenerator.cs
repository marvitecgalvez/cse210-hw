using System;

public class PromptGenerator
{
    public List<string> journalPrompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public string lastPrompt = "";

    /////////////// Mostrar prompts aleatorios
    public string getRandomPrompt()
    {
        Random random = new Random();
        string newPromptIngresed;

        do
        {
            int index = random.Next(journalPrompts.Count);
            newPromptIngresed = journalPrompts[index];
        }
        while (newPromptIngresed == lastPrompt && journalPrompts.Count > 1);

        lastPrompt = newPromptIngresed;
        return newPromptIngresed;
    }

}