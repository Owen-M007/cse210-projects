class BaseGoal
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
//set these below as protected later
    public void SetName()
    {
        Console.Write("what is the name of your goal?: ");
        _name = Console.ReadLine();
    }

    public void SetDescription()
    {
        Console.Write("what is your goal's description?: ");
        _description = Console.ReadLine();
    }

    public void SetNumberOfPoints()
    {
        Console.Write("How many points should be earned for this goal? ");
        _numberOfPoints = int.Parse(Console.ReadLine());
    }
// stop here
    public virtual string GetDisplayString()
    {
        
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

    public int MarkComplete()
    {
        _status = true;
        return _numberOfPoints;
    }
}