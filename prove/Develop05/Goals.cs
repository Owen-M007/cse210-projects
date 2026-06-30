class Goals
{
    private List<BaseGoal> _goals = new List<BaseGoal>();
    private string _filename;
    private int _totalScore;

    public Goals()
    {
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
        
    }
}