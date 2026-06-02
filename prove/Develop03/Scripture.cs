class Scripture
{
    private List<String> _words;
    private Reference _reference;

    // public Scripture(string Book, int Chapter, int Verse, string Text)
    // {
        
    // }

    // public Scripture(string Book, int Chapter, int Verse, int EndVerse, string Text)
    // {
        
    // }

    public Scripture(Reference Ref, string Text)
    {
        _reference = Ref;
        foreach(string Word in Text.Split(" "))
        {
            _words.Add(Word);
        }
    }

    public void RandomWordPicker()
    {
        Random rand = new Random();
        
        for(int i = 0; i < 3; i++)
        {
            int RandomIndex = rand.Next(_words.Count);
        }
    }

    // private List<Word> ConvertToWords(string Text)
    // {
    //     return Text.Split(' ').ToList();
    // }
}