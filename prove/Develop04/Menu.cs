class Menu
{
    private int _userChoice;

    public void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Activity options:");
        Console.WriteLine("  1. Breathing Activity");
        Console.WriteLine("  2. Reflecting Activity");
        Console.WriteLine("  3. Listing Activity");
        Console.WriteLine("  4. Quit");
        Console.Write("> ");
        _userChoice = int.Parse(Console.ReadLine());
        Redirector();
    }

    public void Redirector()
    {
        Console.Clear();
        if (_userChoice == 1)
        {
            Breathing breathingActivity = new Breathing();
            breathingActivity.RunActivity();
        }
        else if (_userChoice == 2)
        {
            Reflecting reflectingActivity = new Reflecting();
            reflectingActivity.RunActivity();
        }
        // else if (_userChoice == 3)
        // {
        //     Listing listingActivity = new Listing();
        //     lisitngActivity.RunActivity();
        // }
        else if (_userChoice == 4)
        {
            return;
        }
    }
}