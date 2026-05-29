class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    private bool _multipleVerse;

    public Reference(string Book, int Chapter, int Verse)
    {
        _book = Book;
        _chapter = Chapter;
        _verse = Verse;
        _multipleVerse = false;
    }

    public Reference(string Book, int Chapter, int Verse, int EndVerse)
    {
        _book = Book;
        _chapter = Chapter;
        _verse = Verse;
        _endVerse = EndVerse;
        _multipleVerse = true;
    }

    // public string GetReference()
    // {
        
    // }


    // keeping this public for now, may change to private if I end up using the commented out method above
    public string GetReferenceString()
    {
        string referenceString;
        
        if(_multipleVerse == false)
        {
            referenceString = $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            referenceString = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }

        return referenceString;
    }

    public void ShowReference()
    {
        Console.WriteLine(GetReferenceString());
    }

    


}