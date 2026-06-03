class Scripture
{
    private List<String> _words = new List<String>();
    private Reference _reference;

    public Scripture(Reference Ref, string Text)
    {
        _reference = Ref;
        foreach(string word in Text.Split(" "))
        {
            _words.Add(word);
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

    public void ShowScripture()
    {
        Console.WriteLine($"{_reference.GetReferenceString()}: {string.Join(" ", _words)}");
    } 
}