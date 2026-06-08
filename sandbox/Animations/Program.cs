class Program
{
    public static void Main(string[] args)
    {
        int sleepTime = 250;
        
        Console.Clear();
        Console.CursorVisible = false;
        for (int i = 0; i< 20; i++)
        {
            Console.Write("+");
            Thread.Sleep(sleepTime);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(sleepTime);
            Console.Write("\b");
        }


        string animationString = "|\\-/";
        for (int i = 0; i< 20; i++)
        {
            Console.Write(animationString[i % animationString.Length]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");
        }
         Console.CursorVisible = true;
    }
}