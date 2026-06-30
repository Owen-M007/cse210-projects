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
        goalType = "simple";
    }

    public override void CreateGoal()
    {
        SetName();
        SetDescription();
        SetNumberOfPoints();
    }

    public override void RecordEvent()
    {
        MarkComplete();
    }
}