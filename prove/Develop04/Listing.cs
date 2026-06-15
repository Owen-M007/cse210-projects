class Listing : Activity
{
    private List<string> _prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are your personal strengths?",
        "Who have you helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
        };

    public Listing() : base("Listing", "This activity will help you reflect on the good in your life by listing as many things as you can in a certain area.")
    {
    }

    public void RunActivity()
    {
        StartActivity();

        Random random = new Random();
        int promptChoice = random.Next(0, _prompts.Count);

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine("");
        Console.WriteLine($"--- {_prompts[promptChoice]} ---");
        Console.WriteLine("");
        RunCountdown("Get ready...", 5);

        do
        {
            Console.Write("> ");
            Console.ReadLine();
        } while(HasTimerExpired() == false);

        Console.WriteLine("");

        DisplayEnding();

        Console.Clear();
    }
}