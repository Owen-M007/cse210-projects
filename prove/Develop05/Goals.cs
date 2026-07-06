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

    public void SaveGoals()
    {
        string fullPath = Path.Combine(_folder, _filename);

        using (StreamWriter outputFile = new StreamWriter(fullPath))
                {
                    outputFile.WriteLine(_totalPoints);
                    foreach (BaseGoal goal in _goals)
                    {
                        outputFile.WriteLine(goal.GetFileSystemString());

                    }
                }
    }

    public void LoadGoals()
    {
        Console.Clear();
        _goals.Clear();
        // _totalPoints = 0;
        Console.WriteLine("Choose a goal folder to load (MM-dd-yyyy):");
        Console.Write("> ");
        string goalsDateChoice = Console.ReadLine();

        // change out date for instead allowing user to put in any filename
        string goalsCompleteChoice = "Goals_" + goalsDateChoice + ".txt";
        string choicePath = Path.Combine(_folder, goalsCompleteChoice);

        // Console.WriteLine("");
        // Console.WriteLine($"Folder opened '{goalsCompleteChoice}'");

        string[] lines = System.IO.File.ReadAllLines(choicePath);
        CreateGoals(lines);
    }

    public void CreateGoals(string[] lines)
    {
        _totalPoints = int.Parse(lines[0]);
        
        for (int i = 1; i <= lines.Length - 1; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(":");
            string goalType = parts[0];
            string[] goalDetails = parts[1].Split(",");

            BaseGoal goal;
            if (goalType == "SimpleGoal")
            {
                goal = new SimpleGoal(goalDetails[0], goalDetails[1], int.Parse(goalDetails[2]), bool.Parse(goalDetails[3]), goalType);
            }
            else if (goalType == "EternalGoal")
            {
                goal = new EternalGoal(goalDetails[0], goalDetails[1], int.Parse(goalDetails[2]), bool.Parse(goalDetails[3]), goalType, int.Parse(goalDetails[4]));
            }
            else
            {
                goal = new ChecklistGoal(goalDetails[0], goalDetails[1], int.Parse(goalDetails[2]), bool.Parse(goalDetails[3]), goalType, int.Parse(goalDetails[4]), int.Parse(goalDetails[5]), int.Parse(goalDetails[6]));
            }

            _goals.Add(goal);
        }
    }
}