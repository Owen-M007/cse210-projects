using System;

class Program
{
    static void Main(string[] args)
    {
        // Word myWord = new Word("Hello");
        // Console.WriteLine(myWord.GetWordString());

        // myWord.Hide();
        // Console.WriteLine(myWord.GetWordString());

        // myWord.DisplayWord();
        // if (myWord.IsHidden())
        // {
        //     Console.WriteLine(myWord.GetWordString());
        // }

        Reference myReference1 = new Reference("1 Nephi", 3, 7);
        // myReference1.ShowReference();

        Reference myReference2 = new Reference("Moroni", 10, 4, 5);
        // myReference2.ShowReference();

        Scripture myScripture1 = new Scripture(myReference1, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        myScripture1.ShowScripture();

        Scripture myScripture2 = new Scripture(myReference2, "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things.");
        myScripture2.ShowScripture();
    }
}