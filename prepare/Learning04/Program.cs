using System;

class Program
{
    static void Main(string[] args)
    {   
        Assignment myAssignment = new Assignment("Owen Means", "Physics");
        Console.WriteLine(myAssignment.GetSummary());

        MathAssignment myMathAssignment = new MathAssignment("7.3", "8-19", "Owen Means", "Math");
        Console.WriteLine(myMathAssignment.GetHomeworkList());
        Console.WriteLine(myMathAssignment.GetSummary());

        WritingAssignment myWritingAssignment = new WritingAssignment("Writing Is Epic", "Owen Means", "English 310");
        Console.WriteLine(myWritingAssignment.GetWritingInfo());
        Console.WriteLine(myWritingAssignment.GetSummary());
    }
}