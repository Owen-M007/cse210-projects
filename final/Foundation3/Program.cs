class Program
{
    static void Main(string[] args)
    {
        // lecture
        Event lecture = new Lecture("speaking", "Bob will be giving a speech about speaking.", "07/23/26", "1:00 PM", "Bob Bobowski", 150);
        lecture.SetAddress("50 W Viking Dr", "Rexburg", "Idaho", "USA");
        lecture.StandardDetails();
        Console.WriteLine("");
        lecture.FullDetails();
        Console.WriteLine("");
        lecture.ShortDetails();

        Console.WriteLine("---------------------------");

        // outdoor gathering
        Event outdoor = new OutdoorGathering("soccer", "Come watch the local team play soccer.", "07/18/26", "4:00 PM", "partly cloudy");
        outdoor.SetAddress("620 S Center St", "Rexburg", "Idaho", "USA");
        outdoor.StandardDetails();
        Console.WriteLine("");
        outdoor.FullDetails();
        Console.WriteLine("");
        outdoor.ShortDetails();

        Console.WriteLine("---------------------------");

        // reception
        Event reception = new Reception("wedding reception", "Come join us as we celebrate the wedding of Bill and Aubrey.", "08/07/26", "6:00 PM", "BillW@gmail.com");
        reception.SetAddress("160 W 2nd S 207", "Rexburg", "Idaho", "USA");
        reception.StandardDetails();
        Console.WriteLine("");
        reception.FullDetails();
        Console.WriteLine("");
        reception.ShortDetails();
    }
}