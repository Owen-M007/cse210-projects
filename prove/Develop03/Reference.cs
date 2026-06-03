class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    private bool _multipleVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _multipleVerse = false;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
        _multipleVerse = true;
    }

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