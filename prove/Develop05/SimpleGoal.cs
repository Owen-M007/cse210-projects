class SimpleGoal : BaseGoal
{
    public SimpleGoal() : base()
    {   
    }

    public SimpleGoal(string name, string description, int points, bool status, string goalType) : base(name, description, points, status)
    {
        SetGoalType(goalType);
    }

    public override void CreateGoal()
    {
        SetName();
        SetDescription();
        SetNumberOfPoints();
    }

    public override int RecordEvent()
    {
        if (GetStatus())
        {
            return 0;
        }
        MarkComplete();
        return GetNumberOfPoints();
    }
}