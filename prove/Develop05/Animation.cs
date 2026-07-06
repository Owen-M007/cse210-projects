class Animation
{
    public void DisplaySpinner()
    {
        string animationString = "/-\\|"; 
            for(int i = 0; i < 20; i++)
            {
                Console.Write(animationString[i % animationString.Length]);
                Thread.Sleep(250);
                Console.Write("\b");
            }
    }

    public void DisplayCompletion()
    {
        string[] completionString = 
        {
            "|          |", 
            "|-         |", 
            "|--        |", 
            "|---       |", 
            "|----      |", 
            "|-----     |", 
            "|------    |", 
            "|-------   |", 
            "|--------  |", 
            "|--------- |",
            "|----------|", 
            "|----------|",
            "|----------|",
            "| ---------|", 
            "|  --------|", 
            "|   -------|", 
            "|    ------|", 
            "|     -----|", 
            "|      ----|", 
            "|       ---|", 
            "|        --|", 
            "|         -|", 
            "|          |", 
            "|         -|", 
            "|        --|", 
            "|       ---|", 
            "|      ----|", 
            "|     -----|", 
            "|    ------|", 
            "|   -------|",
            "|  --------|",
            "| ---------|",
            "|----------|",
            "|----------|",
            "|----------|",
            "|--------- |",
            "|--------  |",
            "|-------   |",
            "|------    |",
            "|-----     |", 
            "|----      |", 
            "|---       |", 
            "|--        |", 
            "|-         |", 
            "|          |", 
        };

        foreach (string frame in completionString)
        {
            Console.Write(frame);
            Thread.Sleep(10);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b");
        }

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Goal accomplished!");
            Thread.Sleep(300);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b                  \b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            Thread.Sleep(300);
        }
    }
}