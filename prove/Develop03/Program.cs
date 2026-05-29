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

        Reference myReference = new Reference("1 Nephi", 2, 8);
        myReference.ShowReference();
    }
}