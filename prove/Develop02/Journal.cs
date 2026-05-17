class Journal
{
    List<JournalEntry> _journalEntries = new List<JournalEntry>();

    public void AddJournalEntry(JournalEntry journalEntry)
    {
        _journalEntries.Add(journalEntry);
    }

    public void DisplayJournal()
    {
        Console.WriteLine("");
        foreach (JournalEntry journalEntry in _journalEntries)
        {
            journalEntry.DisplayJournalEntry();
        }
    }

    public string CreateFileSystemString_Journal()
    {
        List<string> lines = new List<string>();
        foreach (JournalEntry journalEntry in _journalEntries)
        {
            lines.Add(journalEntry.CreateFileSystemString_Entry());
        }

        return string.Join(Environment.NewLine, lines);
    }
}