class EternalGoal : BaseGoal
{
    private int _completions;

    public EternalGoal() : base()
    {   
    }

    public EternalGoal(string name, string description, int points, bool status, string goalType, int completions) : base(name, description, points, status)
    {
        _completions = completions;
        SetGoalType(goalType);
    }

    public override string GetDisplayString()
    {
        return $" - [ ] Type: {GetGoalType()}, Name: {GetName()}, description: {GetDescription()}, Completions: {_completions}, points: {GetNumberOfPoints()}";
    }

    public override string GetFileSystemString()
    {
        return $"{GetGoalType()}:{GetName()},{GetDescription()},{GetNumberOfPoints()},{GetStatus()},{_completions}";
    }

    public override void CreateGoal()
    {
        SetName();
        SetDescription();
        SetNumberOfPoints();
    }

    public override int RecordEvent()
    {
        _completions ++;
        return GetNumberOfPoints();
    }
}