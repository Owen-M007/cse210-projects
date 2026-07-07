class Video
{
    private string _title;
    private string _author;
    private int _length;
    List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count();
    }

    public void DisplayVideo()
    {
        Console.WriteLine("Video:");
        Console.WriteLine($" > '{_title}' by {_author} (Length in seconds: {_length})");
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine("");
    }
}