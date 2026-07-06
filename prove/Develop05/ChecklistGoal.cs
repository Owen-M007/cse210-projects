using System.Drawing;

class ChecklistGoal : BaseGoal
{
    private int _completions;
    private int _maxCompletions;
    private int _bonusPoints;

    public ChecklistGoal() : base()
    {   
    }

    public ChecklistGoal(string name, string description, int points, bool status, string goalType, int completions, int maxCompletions, int bonusPoints) : base(name, description, points, status)
    {
        _completions = completions;
        _maxCompletions = maxCompletions;
        _bonusPoints = bonusPoints;
        SetGoalType(goalType);
    }

    public override string GetDisplayString()
    {
        char statusMarker = ' ';
        if (GetStatus())
        {
            statusMarker = 'X';
        }
        return $" - [{statusMarker}] Type: {GetGoalType()}, Name: {GetName()}, description: {GetDescription()}, Completions: {_completions}/{_maxCompletions}, points: {GetNumberOfPoints()} (completion bonus: {_bonusPoints})";
    }

    public override string GetFileSystemString()
    {
        return $"{GetGoalType()}:{GetName()},{GetDescription()},{GetNumberOfPoints()},{GetStatus()},{_completions},{_maxCompletions},{_bonusPoints}";
    }

    public override void CreateGoal()
    {
        SetName();
        SetDescription();
        ObtainMaxGoal();
        SetNumberOfPoints();
        ObtainBonusPoints();
    }

    public override int RecordEvent()
    {
        if (GetStatus())
        {
            return 0;
        }
        
        _completions ++;
        int pointsEarned = GetNumberOfPoints();
        
        if (_completions == _maxCompletions)
        {
            MarkComplete();
            pointsEarned += _bonusPoints;
        }

        return pointsEarned;
    }

    private void ObtainMaxGoal()
    {
        Console.WriteLine("How many times do you want to do this goal?: ");
        Console.Write("> ");
        _maxCompletions = int.Parse(Console.ReadLine());
    }

    private void ObtainBonusPoints()
    {
        Console.WriteLine("How many bonus points would you like for completing this goal?: ");
        Console.Write("> ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }
}