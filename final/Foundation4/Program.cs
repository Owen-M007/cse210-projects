class Program
{
    static void Main(string[] args)
    {
        Activity swimming = new Swimming("07/20/26", 70, 20);
        Console.WriteLine(swimming.GetSummary());

        Activity running = new Running("07/21/26", 60, 1.6);
        Console.WriteLine(running.GetSummary());
    }
}