class Menu
{
    string _menu;
    int _choice;

    public void DisplayMenu()
    {
        // display menu
        _menu = """
        
        Welcome to your journal!
        1 - Write a new entry
        2 - View current journal
        3 - Save journal
        4 - Load another journal
        5 - Quit program
        What would you like to do?
        """;
    }

    public int UserChoice()
    {
        // returns user-chosen menu item number
        Console.WriteLine(_menu);
        Console.Write("> ");
        string userInput = Console.ReadLine();
        _choice = int.Parse(userInput);
        return _choice;
    }
}