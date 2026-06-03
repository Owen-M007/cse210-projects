using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("1 Nephi", 3, 7);
        Scripture scripture1 = new Scripture(reference1, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");

        Reference reference2 = new Reference("Exodus", 35, 24);
        Scripture scripture2 = new Scripture(reference2, "Every one that did offer an offering of silver and brass brought the Lord's offering: and every man, with whom was found shittim wood for any work of the service, brought it.");

        Reference reference3 = new Reference("Malachi", 2, 10);
        Scripture scripture3 = new Scripture(reference1, "Have we not all one father? hath not one God created us? why do we deal treacherously every man against his brother, by profaning the covenant of our fathers?");

        Reference reference4 = new Reference("Moroni", 7, 45);
        Scripture scripture4 = new Scripture(reference1, "And charity suffereth long, and is kind, and envieth not, and is not puffed up, seeketh not her own, is not easily provoked, thinketh no evil, and rejoiceth not in iniquity but rejoiceth in the truth, beareth all things, believeth all things, hopeth all things, endureth all things.");

        Reference reference5 = new Reference("Moroni", 10, 4, 5);
        Scripture scripture5 = new Scripture(reference2, "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things.");


        Console.WriteLine("Welcome to the Scripture Memorizer! (patent pending (totally (for real)))");
        Console.WriteLine("Please choose a scripture from the following:");
        Console.Write($"1 - "); reference1.ShowReference();
        Console.Write($"2 - "); reference2.ShowReference();
        Console.Write($"3 - "); reference3.ShowReference();
        Console.Write($"4 - "); reference4.ShowReference();
        Console.Write($"5 - "); reference5.ShowReference();
        Console.Write("> ");
        string userChoice = Console.ReadLine();
        Reference chosenReference;
        Scripture chosenScripture;

        if(userChoice == "1")
        {
            chosenReference = reference1;
            chosenScripture = scripture1;
        }
        else if(userChoice == "2")
        {
            chosenReference = reference2;
            chosenScripture = scripture2;
        }
        else if(userChoice == "3")
        {
            chosenReference = reference3;
            chosenScripture = scripture3;
        }
        else if(userChoice == "4")
        {
            chosenReference = reference4;
            chosenScripture = scripture4;
        }
        else if(userChoice == "5")
        {
            chosenReference = reference5;
            chosenScripture = scripture5;
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
                Console.Clear();
                Console.WriteLine("");
                chosenScripture.HideRandomWords();
                Console.Write("Loaded scripture:  ");
                chosenReference.ShowReference();
                chosenScripture.ShowScripture();
                Console.WriteLine("Press Enter to hide three more words, or type 'q' to quit.");
                Console.Write("> ");
            }
        } while (userInput != "q");

    }
}