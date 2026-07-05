class Goals
{
    private List<BaseGoal> _goals = new List<BaseGoal>();
    private string _filename;
    private int _totalPoints;

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
        _goals[userGoalsListChoice - 1].RecordEvent();
        
        _totalPoints += _goals[userGoalsListChoice - 1].GetNumberOfPoints();
    }
}