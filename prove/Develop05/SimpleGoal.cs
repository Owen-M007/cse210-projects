class SimpleGoal : BaseGoal
{
    public SimpleGoal() : base()
    {   
    }

    public SimpleGoal(string name, string description, int points, bool status, string goalType) : base(name, description, points, status)
    {
        name = "";
        description = "";
        status = false;
    }

    public override void CreateGoal()
    {
        SetName();
        SetDescription();
        SetNumberOfPoints();
        SetGoalType("SimpleGoal");
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