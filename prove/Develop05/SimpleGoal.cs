class SimpleGoal : BaseGoal
{
    public SimpleGoal() : base()
    {   
    }

    // public SimpleGoal(string name, string description, int points, bool status) : base()
    // {
        
    // }

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