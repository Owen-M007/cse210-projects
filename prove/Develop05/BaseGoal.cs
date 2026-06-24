abstract class BaseGoal
{
    private string _name;
    private string _description;
    private int _numberOfPoints;
    private bool _status;
    private string _goalType;
    
    public BaseGoal()
    {
        _name = "";
        _description = "";
        _numberOfPoints = 0;
        _status = false;
        _goalType = "";
    }

    protected void SetName()
    {
        Console.Write("what is the name of your goal?: ");
        _name = Console.ReadLine();
    }

    protected void SetDescription()
    {
        Console.Write("what is your goal's description?: ");
        _description = Console.ReadLine();
    }

    protected void SetNumberOfPoints()
    {
        Console.Write("How many points should be earned for this goal? ");
        _numberOfPoints = int.Parse(Console.ReadLine());
    }

    public virtual string GetDisplayString()
    {
        // if this goal is complete, place an X in the status location
        char statusMarker = ' ';
        if (_status)
        {
            statusMarker = 'X';
        }
        return $"[{statusMarker}] Name: {_name}, description: {_description}, points: {_numberOfPoints}";
    }
    
    /*
    MarkComplete will set status to true, which means complete, and
    return the number of points for completing the goal
    */

    protected int MarkComplete()
    {
        _status = true;
        return _numberOfPoints;
    }

    public abstract void CreateGoal();

    public abstract void RecordEvent();
}