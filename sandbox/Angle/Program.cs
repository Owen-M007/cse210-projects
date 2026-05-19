
class Program
{
    public static void Main(string[] args)
    {
        Angle myAngle = new Angle();
        myAngle.SetRadians(10);
        Console.WriteLine(myAngle.GetRadians());
    }
}