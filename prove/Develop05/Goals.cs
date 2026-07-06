class Goals
{
    private List<BaseGoal> _goals = new List<BaseGoal>();
    private int _totalPoints;
    private string _folder = @"C:\Users\ojmea\OneDrive\Documents\VSCodeFiles\CSE210\cse210-projects\prove\Develop05\GoalFolder";
    private string _filename = $"Goals_{DateTime.Now:MM-dd-yyyy}.txt";

    public Goals()
    {
        _totalPoints = 0;
    }

    public void AddGoal(BaseGoal goal)
    {
        _goals.Add(goal);
    }
    
    public void DisplayGoals()
    {
        Console.Clear();
        Console.WriteLine("Your goals are:");
        int number = 1;
        foreach (BaseGoal goal in _goals)
        {
            Console.Write(number);
            Console.WriteLine(goal.GetDisplayString());
            number ++;
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Your total score: {_totalPoints}");
    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal have you accomplished?: ");
        Console.Write("> ");
        int userGoalsListChoice = int.Parse(Console.ReadLine());
        int pointsEarned = _goals[userGoalsListChoice - 1].RecordEvent();
        _totalPoints += pointsEarned;
    }

    // public string CreateFileSystemString()
    // {
    //     List<string> lines = new List<string>();
    //     foreach (BaseGoal goal in _goals)
    //     {
    //         lines.Add(goal.GetFileSystemString());
    //     }

    //     return string.Join(Environment.NewLine, lines);
    // }

    public void SaveGoals()
    {
        string fullPath = Path.Combine(_folder, _filename);

        using (StreamWriter outputFile = new StreamWriter(fullPath))
                {
                    foreach (BaseGoal goal in _goals)
                    {
                        outputFile.WriteLine(goal.GetFileSystemString());

                    }
                }
    }

    public void LoadGoals()
    {
        Console.Clear();
        Console.WriteLine("Choose a goal folder to load (MM-dd-yyyy):");
        Console.Write("> ");
        string goalsDateChoice = Console.ReadLine();

        // ----- TO DO: change out date to instead allow user to put in any filename -----
        string goalsCompleteChoice = "Goals_" + goalsDateChoice + ".txt";
        string choicePath = Path.Combine(_folder, goalsCompleteChoice);

        Console.WriteLine("");
        Console.WriteLine($"Folder opened '{goalsCompleteChoice}'");

        string[] lines = System.IO.File.ReadAllLines(choicePath);
        CreateGoals(lines);

    }

    public void CreateGoals(string[] lines)
    {
        foreach (string line in lines)
        {
            string[] parts = line.Split(":");
            string goalType = parts[0];
            string goalDetails = parts[1];

            BaseGoal goal;
            if (goalType == "SimpleGoal")
            {
                goal = new SimpleGoal();
            }
            else if (goalType == "EternalGoal")
            {
                goal = new EternalGoal();
            }
            else
            {
                goal = new ChecklistGoal();
            }

            _goals.Add(goal);
        }

        
    }
}