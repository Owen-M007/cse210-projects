using System;

class Program
{
    static void Main(string[] args)
    {
        // display menu
        Menu myMenu = new Menu();
        myMenu.DisplayMenu();
        
        // new journal entry
        JournalEntry myJournalEntry = new JournalEntry();
        myJournalEntry.CreateJournalEntry();
        // myJournalEntry.DisplayJournalEntry();
        // Console.WriteLine(myJournalEntry.CreateFileSystemString());

        // add entry to a journal
        Journal myJournal = new Journal();
        myJournal.AddJournalEntry(myJournalEntry);
        myJournal.DisplayJournal();   
    }


}