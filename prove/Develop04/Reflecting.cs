using System.Security.Cryptography;

class Reflecting : Activity
{
    private List<string> _prompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
        };
    private List<string> _questions = new List<string> {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
        };

    
    public Reflecting() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
    }
    
    public void RunActivity()
    {
        StartActivity();

        Random random = new Random();
        int promptChoice = random.Next(0, _prompts.Count);
        int questionChoice = random.Next(0, _questions.Count);

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");
        Console.WriteLine($"--- {_prompts[promptChoice]} ---");
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.Write("> ");

        ConsoleKey allowedKey = ConsoleKey.Enter;
        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key == allowedKey)
            {
                break;
            }
        }

        Console.WriteLine("");
        Console.WriteLine("Now reflect and ponder on each of the following questions as they relate to this experience.");
        RunCountdown("Get ready...", 5);

        Console.Clear();
        
        do
        {
            Console.Write($"> {_questions[questionChoice]} ");
            DisplaySpinner(20);
            Console.WriteLine("");
        } while(HasTimerExpired() == false);

        DisplayEnding();
    }
}