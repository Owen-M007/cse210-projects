using System;

class Program
{
    static void Main(string[] args)
    {
        BaseGoal myBaseG = new BaseGoal();
        myBaseG.SetName();
        myBaseG.SetDescription();
        myBaseG.SetNumberOfPoints();
        Console.WriteLine(myBaseG.GetDisplayString());
        myBaseG.MarkComplete();
        Console.WriteLine(myBaseG.GetDisplayString());
    }
}