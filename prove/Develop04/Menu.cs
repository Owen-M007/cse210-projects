class Menu
{
    private int _userChoice;

    public void DisplayMenu()
    {
        Console.Clear();
        
        while (true)
        {
            Console.WriteLine("Activity options:");
            Console.WriteLine("  1. Breathing Activity");
            Console.WriteLine("  2. Reflecting Activity");
            Console.WriteLine("  3. Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("> ");
            _userChoice = int.Parse(Console.ReadLine());
            
            if (_userChoice == 4)
            {   
                Console.CursorVisible = false;

                Console.Clear();

                Console.WriteLine("Goodbye!");
                Console.WriteLine("");

                for(int i = 0; i < 5; i++)
                {
                    Console.Write(":)");
                    Thread.Sleep(500);
                    Console.Write("\b\b  \b\b");
                    Console.Write(":D");
                    Thread.Sleep(500);
                    Console.Write("\b\b  \b\b");
                }

                Console.Clear();
                break;
            }
            Redirector();
        }
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
        else if (_userChoice == 3)
        {
            Listing listingActivity = new Listing();
            listingActivity.RunActivity();
        }
    }
}