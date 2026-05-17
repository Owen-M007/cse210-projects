using System;

class Program
{
    static void Main(string[] args)
    {
        // display menu
        Menu myMenu = new Menu();
        myMenu.DisplayMenu();

        // create journal
        Journal myJournal = new Journal();

        // user chooses number and program responds to their choice
        int choice = myMenu.UserChoice();
        while (choice != 5)
        {
            if (choice == 1) 
            {
                // new journal entry
                JournalEntry myJournalEntry = new JournalEntry();
                myJournalEntry.CreateJournalEntry();

                // add entry to a journal
                myJournal.AddJournalEntry(myJournalEntry);

                // return to menu
                myMenu.DisplayMenu();
            }

            else if (choice == 2)
            {
                // view current journal
                myJournal.DisplayJournal();

                // return to menu
                myMenu.DisplayMenu();
            }
        }
                

        // myJournalEntry.DisplayJournalEntry();
        // Console.WriteLine(myJournalEntry.CreateFileSystemString());

    }


}