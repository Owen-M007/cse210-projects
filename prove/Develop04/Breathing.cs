class Breathing : Activity
{
    public Breathing() : base("Breathing", "This activity will help you relax by slowly walking you through your breathing in and out.")
    {
    }

    public void RunActivity()
    {
        StartActivity();
        
        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplaySpinner(15);
        
        do
        {
            RunCountdown("Breathe in...", 4);
            RunCountdown("And breathe out...", 6);
        } while(HasTimerExpired() == false);

        DisplayEnding();
    }

    
}