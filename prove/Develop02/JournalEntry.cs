class JournalEntry
{
    string _date;
    string _prompt;
    string _response;

    string[] _prompts =
    {
        "How are you feeling today?",
        "Wat was the most interesting interaction you had today?",
        "What was the best part of your day?",
        "How did you see the hand of the Lord in your life today?",
        "What was the strongest emotion you felt today?",
        "If you had one thing you could do over today, what would it be?"
    };
    
    public void CreateJournalEntry()
    {
        _date = DateTime.Now.ToShortDateString();

        // finish this code - need a random prompt
        _prompt = _prompts[0];
        Console.WriteLine(_prompt);
        _response = Console.ReadLine();
        _prompt = _prompts[0];
    }

    public void DisplayJournalEntry()
    {
        Console.WriteLine($"{_date}, {_prompt}, {_response}");
    }

    public string CreateFileSystemString()
    {
        return $"{_date}#{_prompt}#{_response}";
    }
}