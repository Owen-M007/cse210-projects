using System.Drawing;

class ChecklistGoal : BaseGoal
{
    private int _completions;
    private int _maxCompletions;
    private int _bonusPoints;

    public ChecklistGoal() : base()
    {   
    }

    public ChecklistGoal(string name, string description, int points, bool status, string goalType, int maxCompletions, int bonusPoints) : base(name, description, points, status)
    {
        name = "";
        description = "";
        status = false;
        maxCompletions = 0;
        bonusPoints = 0;
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

    public override void CreateGoal()
    {
        SetName();
        SetDescription();
        ObtainMaxGoal();
        SetNumberOfPoints();
        ObtainBonusPoints();
        SetGoalType("checklist");
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
        Console.Write("how many times do you want to do this goal?: ");
        _maxCompletions = int.Parse(Console.ReadLine());
    }

    private void ObtainBonusPoints()
    {
        Console.Write("how many bonus points would you like for completing this goal?: ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }
}