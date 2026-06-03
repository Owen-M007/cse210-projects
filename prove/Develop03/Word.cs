// Word class contains the word. If the word is hidden, GetWordSTring will return _ characters (one for each character in the word)
class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    // Return either the word, if not hidden, or the _s if hidden
    public string GetWordString()
    {
        string tempWord = "";
        if (_hidden)
        {
            foreach(char c in _word)
            {
                tempWord += '_';
            }
        }
        else
        {
            tempWord = _word;
        }
        return tempWord;
    }

    // Hide a word
    public void Hide()
    {
        _hidden = true;
    }

    // display the word, whether unchanged or hidden
    public void DisplayWord()
    {
        Console.WriteLine(GetWordString());
    }
}