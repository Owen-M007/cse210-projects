class Scripture
{
    private List<Word> _words = new List<Word>();

    public Scripture(string Text)
    {
        foreach (string word in Text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    // Picks 3 random words from the text
    public List<int> RandomWordPicker(int count = 3)
    {
        List<int> hiddenIndices = new List<int>();
        Random rand = new Random();

        while (hiddenIndices.Count < count && hiddenIndices.Count < _words.Count)
        {
            int randomIndex = rand.Next(_words.Count);
            if (!hiddenIndices.Contains(randomIndex))
            {
                hiddenIndices.Add(randomIndex);
            }
        }
        return hiddenIndices;
    }

    // Hides the 3 random words picked
    public void HideRandomWords(int count = 3)
    {
        foreach (int index in RandomWordPicker(count))
        {
            _words[index].Hide();
        }
    }

    // Tells once all words are hidden
    public bool AllFinished()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    // Writes the scriptures' text to the console
    public void ShowScripture()
    {
        List<string> displayWords = new List<string>();
        foreach (Word word in _words)
        {
            displayWords.Add(word.GetWordString());
        }

        Console.WriteLine(string.Join(" ", displayWords));
    }
}