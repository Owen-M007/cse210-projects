using System;

class Program
{
    static void Main(string[] args)
    {
        Event lecture = new Lecture("speaking", "Bob will be speaking about speaking", "07/23/26", "1:00 PM", "Bob Bobowski", 150);
        lecture.SetAddress("650 S 1st W", "Rexburg", "Idaho", "USA");
        lecture.StandardDetails();
        Console.WriteLine("");
        lecture.FullDetails();
        Console.WriteLine("");
        lecture.ShortDetails();
    }
}