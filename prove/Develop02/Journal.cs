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

    public void CreateFileSystemString_Journal()
    {
        foreach (JournalEntry journalEntry in _journalEntries)
        {
            journalEntry.CreateFileSystemString_Entry();
        }
    }
}