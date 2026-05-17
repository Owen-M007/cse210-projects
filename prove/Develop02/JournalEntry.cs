class JournalEntry
{
    string _date;
    string _prompt;
    string _response;

    // finish code - need more prompts
    string[] _prompts =
    {
        "How are you feeling today?",
        "Who did you talk with today?"
    };
    
    public void CreateJournalEntry()
    {
        _date = DateTime.Now.ToShortDateString();

        // finish this code - need a random prompt
        _prompt = _prompts[0];
        Console.Write(_prompt);
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