class JournalEntry
{
    Random randomGenerator = new Random();
    public string _date;
    string _prompt;
    string _response;
    string[] _prompts =
    {
        "How are you feeling today?",
        "What was the most interesting interaction you had today?",
        "What was the best part of your day?",
        "How did you see the hand of the Lord in your life today?",
        "What was the strongest emotion you felt today?",
        "If you had one thing you could do over today, what would it be?"
    };
    List<int> _usedPrompts = new List<int>();
    
    public void CreateJournalEntry()
    {
        _date = DateTime.Now.ToShortDateString();

        // display random prompt and user gives response
        int promptChoice = randomGenerator.Next(0,5);
        while (_usedPrompts.Contains(promptChoice))
        {
            promptChoice = randomGenerator.Next(0,5);
        }
        _usedPrompts.Add(promptChoice);
        _prompt = _prompts[promptChoice];

        Console.WriteLine("");
        Console.WriteLine(_prompt);
        Console.Write("> ");
        _response = Console.ReadLine();
    }

    public void DisplayJournalEntry()
    {
        Console.WriteLine($"DATE: {_date} - PROMPT: {_prompt}");
        Console.WriteLine($"{_response}");
    }

    public string CreateFileSystemString_Entry()
    {
        return $"{_date}|{_prompt}|{_response}";
    }
}