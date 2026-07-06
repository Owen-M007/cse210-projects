class EternalGoal : BaseGoal
{
    private int _completions;

    public EternalGoal() : base()
    {   
    }

    public EternalGoal(string name, string description, int points, bool status, string goalType, int completions) : base(name, description, points, status)
    {
        name = "";
        description = "";
        status = false;
        completions = 0;
    }

    public override string GetDisplayString()
    {
        return $" - [ ] Type: {GetGoalType()}, Name: {GetName()}, description: {GetDescription()}, Completions: {_completions}, points: {GetNumberOfPoints()}";
    }

    public override void CreateGoal()
    {
        SetName();
        SetDescription();
        SetNumberOfPoints();
        SetGoalType("EternalGoal");
    }

    public override int RecordEvent()
    {
        _completions ++;
        return GetNumberOfPoints();
    }
}