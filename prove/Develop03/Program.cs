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

        Reference myReference1 = new Reference("1 Nephi", 2, 8);
        myReference1.ShowReference();

        Reference myReference2 = new Reference("Moroni", 10, 4, 5);
        myReference2.ShowReference();
    }
}