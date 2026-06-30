class Menu
{
    private int _userChoice;

    private int _userGoalChoice;

    private Goals _goals = new Goals();

    public void DisplayMenu()
    {
        
        while (true)
        {
            Console.Clear();
            // Goals.DisplayScore();
            // Console.WriteLine("")
            Console.WriteLine("Menu options:");
            Console.WriteLine("  1. Create new goal");
            Console.WriteLine("  2. List goals");
            Console.WriteLine("  3. Save goals");
            Console.WriteLine("  4. Load goals");
            Console.WriteLine("  5. Record event");
            Console.WriteLine("  6. Quit");
            Console.Write("> ");
            _userChoice = int.Parse(Console.ReadLine());
            
            if (_userChoice == 6)
            {   
                // Console.CursorVisible = false;

                // Console.Clear();

                // Console.WriteLine("Goodbye!");
                // Console.WriteLine("");

                // for(int i = 0; i < 5; i++)
                // {
                //     Console.Write(":)");
                //     Thread.Sleep(500);
                //     Console.Write("\b\b  \b\b");
                //     Console.Write(":D");
                //     Thread.Sleep(500);
                //     Console.Write("\b\b  \b\b");
                // }

                Console.Clear();
                break;
            }
            Redirector();
        }
    }

    public void Redirector()
    {
        Console.Clear();
        if (_userChoice == 1) // Create new goal
        {
            Console.WriteLine("Choose a type of goal:");
            Console.WriteLine("  1. Simple goal");
            Console.WriteLine("  2. Eternal goal");
            Console.WriteLine("  3. Checklist goal");
            Console.Write("> ");
            _userGoalChoice = int.Parse(Console.ReadLine());
            
            if (_userGoalChoice == 1)
            {
                SimpleGoal simpleGoal = new SimpleGoal();
                simpleGoal.CreateGoal();
                _goals.AddGoal(simpleGoal);
            }
            // else if (_userGoalChoice == 2)
            // {
                
            // }
            // else if (_userGoalChoice == 3)
            // {
                
            // }
                
        }
        else if (_userChoice == 2) // List goals
        {
            _goals.DisplayGoals();
            Console.WriteLine("Press enter to return: ");
            Console.Write("> ");
            Console.ReadKey(intercept: true);
        }
        // else if (_userChoice == 3) // Save goals
        // {
            
        // }
        // else if (_userChoice == 4) // Load goals
        // {
            
        // }
        else if (_userChoice == 5) // Record event
        {
            _goals.DisplayGoals();
            Console.WriteLine("Which goal have you accomplished?: ");
            Console.Write("> ");
            
        }
    }
}