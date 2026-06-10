class Activity
{
    private string _name;
    private string _description;
    private int _duration; // duration of activity (user input)
    private DateTime _endTime;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
        _endTime = DateTime.Now;
    }

    public void StartActivity()
    {
        Console.WriteLine($"Welcome to the {_name} activity");
        Console.WriteLine(_description);
        Console.WriteLine("How many seconds for this activity?");
        Console.Write("> ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void RunCountdown(string message, int duration) // duration here is just for how long we want the thing to pop up on the screen
    {
        Console.Write($"{message}: ");
        while(duration >= 0)
        {
            Console.Write($"{duration--, 2}");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
        Console.WriteLine("");
    }
}