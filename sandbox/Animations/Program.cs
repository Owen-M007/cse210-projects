class Program
{
    public static void Main(string[] args)
    {
        int sleepTime = 250;
        
        Console.Clear();
        Console.CursorVisible = false;
        // for (int i = 0; i< 20; i++)
        // {
        //     Console.Write("+");
        //     Thread.Sleep(sleepTime);
        //     Console.Write("\b");
        //     Console.Write("-");
        //     Thread.Sleep(sleepTime);
        //     Console.Write("\b");
        // }


        // string animationString = "/-\\|"; 
        // for (int i = 0; i< 30; i++)
        // {
        //     Console.Write(animationString[i % animationString.Length]);
        //     Thread.Sleep(sleepTime);
        //     Console.Write("\b");
        // }


        int count = 10;
        int index = 0;

        // DateTime now = DateTime.Now;
        // DateTime endTime = now.AddSeconds(count);
        // while (DateTime.Now < endTime)
        // {
        //     Console.Write(animationString[index++ % animationString.Length]);
        //     Thread.Sleep(sleepTime);
        //     Console.Write("\b");
        // }

        
        // while (DateTime.Now < endTime)
        while(count >= 0)
        {
            Console.Write($"{count--, 2}");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }

         Console.CursorVisible = true;
    }
}