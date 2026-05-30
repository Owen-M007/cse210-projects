class Scripture
{
    private List<Word> _words;
    private Reference _reference;

    public Scripture(string Book, int Chapter, int Verse, string Text)
    {
        
    }

    public Scripture(string Book, int Chapter, int Verse, int EndVerse, string Text)
    {
        
    }

    public Scripture(Reference Ref, string Text)
    {
        _reference = Ref.GetReferenceString()

    }

    // private List<Word> ConvertToWords(string Text)
    // {
    //     return Text.Split(' ').ToList();
    // }
}