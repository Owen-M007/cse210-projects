class Program
{
    static void Main(string[] args)
    {
        Activity swimming = new Swimming("07/20/26", 70, 20);
        Activity running = new Running("07/21/26", 60, 1.6);
        Activity cycling = new Cycling("07/22/26", 30, 2);

        List<Activity> activityList = [swimming, running, cycling];
        foreach (Activity activity in activityList)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}