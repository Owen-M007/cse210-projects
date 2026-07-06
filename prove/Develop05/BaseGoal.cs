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

    public BaseGoal(string name, string description, int points, bool status)
    {
        _name = name;
        _description = description;
        _numberOfPoints = points;
        _status = status;
    }

    protected void SetName()
    {
        Console.WriteLine("What is the name of your goal?: ");
        Console.Write("> ");
        _name = Console.ReadLine();
    }

    public string GetName()
    {
        return _name;
    }

    protected void SetDescription()
    {
        Console.WriteLine("What is your goal's description?: ");
        Console.Write("> ");
        _description = Console.ReadLine();
    }

    public string GetDescription()
    {
        return _description;
    }
    
    protected void SetNumberOfPoints()
    {
        Console.WriteLine("How many points should be earned for this goal?: ");
        Console.Write("> ");
        _numberOfPoints = int.Parse(Console.ReadLine());
    }

    public int GetNumberOfPoints()
    {
        return _numberOfPoints;
    }

    public void SetGoalType(string goalType)
    {
        _goalType = goalType;
    }
    
    public string GetGoalType()
    {
        return _goalType;
    }

    public bool GetStatus()
    {
        return _status;
    }

    public virtual string GetDisplayString()
    {
        // if this goal is complete, place an X in the status location
        char statusMarker = ' ';
        if (_status)
        {
            statusMarker = 'X';
        }
        return $" - [{statusMarker}] Type: {_goalType}, Name: {_name}, description: {_description}, points: {_numberOfPoints}";
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

    public abstract int RecordEvent();

    public abstract void CreateGoal();

    public virtual string GetFileSystemString()
    {
        return $"{_goalType}:{_name},{_description},{_numberOfPoints},{_status}";
    }
}