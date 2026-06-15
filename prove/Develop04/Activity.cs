class Activity
{
    private string _name;
    private string _description;
    private int _activityDuration; // duration of activity (user input)
    private DateTime _endTime;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _activityDuration = 0;
        _endTime = DateTime.Now;
    }

    public void StartActivity()
    {
        Console.WriteLine($"Welcome to the {_name} Activity!");
        Console.WriteLine(_description);
        Console.WriteLine("How long (in seconds) would you like to do this activity?");
        Console.Write("> ");
        _activityDuration = int.Parse(Console.ReadLine());
        _endTime = DateTime.Now.AddSeconds(_activityDuration);

        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplaySpinner(15);
    }

    public void DisplayEnding()
    {
        Console.WriteLine("Well done!");
        DisplaySpinner(15);
        Console.WriteLine($"You have completed {_activityDuration} seconds of the {_name} Activity.");
        DisplaySpinner(15);
    }

    public void RunCountdown(string message, int duration) // duration here is just for how long we want the thing to pop up on the screen
    {
        Console.CursorVisible = false;
        Console.Write($"{message} ");
        while(duration > 0)
        {
            Console.Write($"{duration--, 2}");
            Thread.Sleep(1000);
            Console.Write("\b\b  \b\b");
        }
        Console.WriteLine("");
        Console.CursorVisible = true;
    }

    public void DisplaySpinner(int duration) // duration here is same as above comment
    {
        Console.CursorVisible = false;
        int sleepTime = 250;

        string animationString = "/-\\|"; 
        for(int i = 0; i < duration; i++)
        {
            Console.Write(animationString[i % animationString.Length]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");
        }
        Console.Write(" ");
        Console.WriteLine("");
        Console.CursorVisible = true;
    }

    public bool HasTimerExpired()
    {
        return DateTime.Now >= _endTime;
    }
}