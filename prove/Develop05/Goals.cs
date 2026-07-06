class Goals
{
    private List<BaseGoal> _goals = new List<BaseGoal>();
    private int _totalPoints;
    private string _folder = @"C:\Users\ojmea\OneDrive\Documents\VSCodeFiles\CSE210\cse210-projects\prove\Develop05\GoalFolder";
    private string _filename;

    private Animation _animations = new Animation();

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
        Console.Clear();
        Console.WriteLine("What would you like to name your goals file?: ");
        Console.Write("> ");
        _filename = Console.ReadLine() + ".txt";

        Console.CursorVisible = false;
        Console.WriteLine("");
        Console.WriteLine($"Saved to file as '{_filename}' ");
        
        _animations.DisplaySpinner();
        Console.CursorVisible = true;

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
        Console.WriteLine("Choose a goals file to load:");
        Console.Write("> ");
        string fileChoice = Console.ReadLine() + ".txt";

        string pathChoice = Path.Combine(_folder, fileChoice);

        Console.CursorVisible = false;
        Console.WriteLine("");
        Console.WriteLine($"File opened '{fileChoice}' ");


        _animations.DisplaySpinner();
        Console.CursorVisible = true;

        string[] lines = System.IO.File.ReadAllLines(pathChoice);
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