using System;
using System.Collections.Generic;

class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;
    private static readonly Random _rand = new Random();

    public Scripture(Reference Ref, string Text)
    {
        _reference = Ref;
        foreach (string word in Text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public List<int> RandomWordPicker(int count = 3)
    {
        List<int> hiddenIndices = new List<int>();

        while (hiddenIndices.Count < count && hiddenIndices.Count < _words.Count)
        {
            int randomIndex = _rand.Next(_words.Count);
            if (!hiddenIndices.Contains(randomIndex))
            {
                hiddenIndices.Add(randomIndex);
            }
        }

        return hiddenIndices;
    }

    public void HideRandomWords(int count = 3)
    {
        foreach (int index in RandomWordPicker(count))
        {
            _words[index].Hide();
        }
    }

    public void ShowScripture()
    {
        List<string> displayWords = new List<string>();
        foreach (Word word in _words)
        {
            displayWords.Add(word.GetWordString());
        }

        Console.WriteLine($"{_reference.GetReferenceString()}: {string.Join(" ", displayWords)}");
    }
}