using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // create journal
        Journal myJournal = new Journal();
        string folder = @"C:\Users\ojmea\OneDrive\Documents";
        string filename = $"Journal_{DateTime.Now.ToShortDateString()}.txt";
        string fullPath = Path.Combine(folder, filename);

        // user chooses number and program responds to their choice
        int? choice = null;
        
        while (choice != 5)
        {
            // display menu
            Menu myMenu = new Menu();
            myMenu.DisplayMenu();
            choice = myMenu.UserChoice();

            if (choice == 1) 
            {
                // new journal entry
                JournalEntry myJournalEntry = new JournalEntry();
                myJournalEntry.CreateJournalEntry();

                // add entry to a journal
                myJournal.AddJournalEntry(myJournalEntry);
            }

            else if (choice == 2)
            {
                // view current journal
                myJournal.DisplayJournal();
            }

            else if (choice == 3)
            {
                // save journal
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    outputFile.Write(myJournal.CreateFileSystemString_Journal());
                }
                Console.WriteLine($"Journal saved to {filename}");
            }

            else if (choice == 4)
            {
                // load another journal
            }
        }

        // myJournalEntry.DisplayJournalEntry();
        // Console.WriteLine(myJournalEntry.CreateFileSystemString());
    }
}