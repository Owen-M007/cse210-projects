class Menu
{
    public int DisplayMenu()
    {
        Console.WriteLine("Activity options:");
        Console.WriteLine("  1. Breathing Activity");
        Console.WriteLine("  2. Reflecting Activity");
        Console.WriteLine("  3. Listing Activity");
        Console.WriteLine("  4. Quit");
        return int.Parse(Console.ReadLine());
    }

    public void Redirector()
    {
        Console.Clear();
        if (DisplayMenu() == 1)
        {
            Breathing breathingActivity = new Breathing();
            breathingActivity.RunActivity();
        }
        else if (DisplayMenu() == 2)
        {
            Reflecting reflectingActivity = new Reflecting();
            reflectingActivity.RunActivity();
        }
        // else if (DisplayMenu() == 3)
        // {
        //     Listing listingActivity = new Listing();
        //     lisitngActivity.RunActivity();
        // }
        else if (DisplayMenu() == 4)
        {
            return;
        }
    }
}