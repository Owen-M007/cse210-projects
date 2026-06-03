class Menu
{
    // The references and their accompanying texts
    private Reference _reference1 = new Reference("1 Nephi", 3, 7);
    private Scripture _scripture1 = new Scripture("And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");

    private Reference _reference2 = new Reference("Exodus", 35, 24);
    private Scripture _scripture2 = new Scripture("Every one that did offer an offering of silver and brass brought the Lord's offering: and every man, with whom was found shittim wood for any work of the service, brought it.");

    private Reference _reference3 = new Reference("Malachi", 2, 10);
    private Scripture _scripture3 = new Scripture("Have we not all one father? hath not one God created us? why do we deal treacherously every man against his brother, by profaning the covenant of our fathers?");

    private Reference _reference4 = new Reference("Moroni", 7, 45);
    private Scripture _scripture4 = new Scripture("And charity suffereth long, and is kind, and envieth not, and is not puffed up, seeketh not her own, is not easily provoked, thinketh no evil, and rejoiceth not in iniquity but rejoiceth in the truth, beareth all things, believeth all things, hopeth all things, endureth all things.");

    private Reference _reference5 = new Reference("Moroni", 10, 4, 5);
    private Scripture _scripture5 = new Scripture("And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things.");
    
    // Displays the menu (and rest of user interface)
    public void DisplayMenu()
    {
        Console.WriteLine("Welcome to the Scripture Memorizer! (patent pending (totally (for real)))");
        Console.WriteLine("Please choose a scripture from the following:");
        Console.Write($"1 - "); _reference1.ShowReference();
        Console.Write($"2 - "); _reference2.ShowReference();
        Console.Write($"3 - "); _reference3.ShowReference();
        Console.Write($"4 - "); _reference4.ShowReference();
        Console.Write($"5 - "); _reference5.ShowReference();
        Console.Write("> ");
        string userChoice = Console.ReadLine();
        Reference chosenReference;
        Scripture chosenScripture;

        if(userChoice == "1")
        {
            chosenReference = _reference1;
            chosenScripture = _scripture1;
        }
        else if(userChoice == "2")
        {
            chosenReference = _reference2;
            chosenScripture = _scripture2;
        }
        else if(userChoice == "3")
        {
            chosenReference = _reference3;
            chosenScripture = _scripture3;
        }
        else if(userChoice == "4")
        {
            chosenReference = _reference4;
            chosenScripture = _scripture4;
        }
        else if(userChoice == "5")
        {
            chosenReference = _reference5;
            chosenScripture = _scripture5;
        }
        else
        {
            Console.WriteLine("Invalid input, pick a number between 1 and 5.");
            return;
        }

        Console.Clear();


        Console.WriteLine("Press Enter to hide three words, or type 'q' to quit.");
        Console.WriteLine("");
        Console.Write("Loaded scripture:  ");
        chosenReference.ShowReference();
        chosenScripture.ShowScripture();
        Console.Write("> ");
        string userInput;
        do
        {
            userInput = Console.ReadLine();
            if (userInput != "q")
            {
                if (chosenScripture.AllFinished())
                {
                    break;
                }
                Console.Clear();
                Console.WriteLine("Press Enter to hide three more words, or type 'q' to quit.");
                Console.WriteLine("");
                chosenScripture.HideRandomWords();
                Console.Write("Loaded scripture:  ");
                chosenReference.ShowReference();
                chosenScripture.ShowScripture();
                Console.Write("> ");
            }
        } while (userInput != "q");
    }
}