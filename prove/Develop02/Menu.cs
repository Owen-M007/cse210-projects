class Menu
{
    string _menu;

    public void DisplayMenu()
    {
        Console.WriteLine("Welcome to your journal!");
        Console.WriteLine("1 - Write a new entry");
        Console.WriteLine("2 - View current journal");
        Console.WriteLine("3 - Save journal");
        Console.WriteLine("4 - Load another journal");
        Console.WriteLine("5 - Quit program");
        Console.WriteLine("What would you like to do?");
        Console.Write("> ");
        string userInput = Console.ReadLine();
        int choice = int.Parse(userInput);
    }
    
    public void Redirect()
    {
        
    }
}