class Menu
{
    private int _userChoice;

    private int _userGoalChoice;

    private Goals _goals = new Goals();

    private Animation _animations = new Animation();

    public void DisplayMenu()
    {   
        while (true)
        {
            Console.Clear();
            _goals.DisplayScore();
            Console.WriteLine("");
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
                Console.Clear();

                Console.CursorVisible = false;

                Console.WriteLine("Goodbye! ");
                
                _animations.DisplaySpinner();

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
            
            if (_userGoalChoice == 1) // Simple goal
            {
                BaseGoal simpleGoal = new SimpleGoal();
                simpleGoal.CreateGoal();
                simpleGoal.SetGoalType("SimpleGoal");
                _goals.AddGoal(simpleGoal);
            }
            else if (_userGoalChoice == 2) // Eternal goal
            {
                BaseGoal eternalGoal = new EternalGoal();
                eternalGoal.CreateGoal();
                eternalGoal.SetGoalType("EternalGoal");
                _goals.AddGoal(eternalGoal);
            }
            else if (_userGoalChoice == 3) // Checklist goal
            {
                BaseGoal checklistGoal = new ChecklistGoal();
                checklistGoal.CreateGoal();
                checklistGoal.SetGoalType("ChecklistGoal");
                _goals.AddGoal(checklistGoal);
            }
                
        }
        else if (_userChoice == 2) // List goals
        {
            _goals.DisplayGoals();
            Console.WriteLine("Press enter to return: ");
            Console.Write("> ");
            Console.ReadKey(intercept: true);
        }
        else if (_userChoice == 3) // Save goals
        {
            _goals.SaveGoals();
        }
        else if (_userChoice == 4) // Load goals
        {
            _goals.LoadGoals();
        }
        else if (_userChoice == 5) // Record event
        {
            _goals.DisplayGoals();
            _goals.RecordEvent();

            Console.Clear();
            Console.CursorVisible = false;
            
            _animations.DisplayCompletion();

            Console.Clear();
            Console.CursorVisible = true;

            _goals.DisplayGoals();
            Console.WriteLine("Press enter to return: ");
            Console.Write("> ");
            Console.ReadKey(intercept: true);
        }
    }
}