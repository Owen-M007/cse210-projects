using System;

class Program
{
    static void Main(string[] args)
    {
        Event lecture = new Lecture("speaking", "Bob will be speaking about speaking", "07/23/26", "1:00 PM", "Bob Bobowski", 150);
        lecture.SetAddress("50 W Viking Dr", "Rexburg", "Idaho", "USA");
        lecture.StandardDetails();
        Console.WriteLine("");
        lecture.FullDetails();
        Console.WriteLine("");
        lecture.ShortDetails();

        Console.WriteLine("---------------------------");

        Event outdoor = new OutdoorGathering("soccer", "come watch the local team play soccer", "07/18/26", "4:00 PM", "partly cloudy");
        outdoor.SetAddress("620 S Center St", "Rexburg", "Idaho", "USA");
        outdoor.StandardDetails();
        Console.WriteLine("");
        outdoor.FullDetails();
        Console.WriteLine("");
        outdoor.ShortDetails();
    }
}