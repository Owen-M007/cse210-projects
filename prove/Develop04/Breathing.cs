class Breathing : Activity
{
    public Breathing(string description) : base("breathing", description)
    {
    }

    public void RunActivity()
    {
        StartActivity();
        RunCountdown("Breath in", 4);
        RunCountdown("Breath out", 6);
    }

    
}