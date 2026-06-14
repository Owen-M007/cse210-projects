using System.Diagnostics;

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
        Console.WriteLine($"Welcome to the {_name} activity");
        Console.WriteLine(_description);
        Console.WriteLine("How long (in seconds) would you like to do this activity?");
        Console.Write("> ");
        _activityDuration = int.Parse(Console.ReadLine());
        _endTime = DateTime.Now.AddSeconds(_activityDuration);
    }

    public void RunCountdown(string message, int duration) // duration here is just for how long we want the thing to pop up on the screen
    {
        Console.CursorVisible = false;
        Console.Write($"{message}: ");
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
        int sleepTime = 250;

        string animationString = "/-\\|"; 
        for(int i = 0; i < duration; i++)
        {
            Console.Write(animationString[i % animationString.Length]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");
        }
    }

    public bool HasTimerExpired()
    {
        return DateTime.Now >= _endTime;
    }
}