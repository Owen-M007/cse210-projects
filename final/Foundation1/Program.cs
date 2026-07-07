class Program
{
    static void Main(string[] args)
    {
        // Video 1
        Video video1 = new Video("Classing With Programs!? A Sharp C Tutorial", "Billy Bart", 1200);

        Comment comment1_1 = new Comment("EpicCoder123", "It was totally epic when he abstracted the encapsulation, it made me want to inherit some polymorphism.");
        Comment comment1_2 = new Comment("Dude", "Wow.");
        Comment comment1_3 = new Comment("Nuh-Uh", "I Disagree with everything you said, 0/10 tutorial.");

        video1.AddComment(comment1_1);
        video1.AddComment(comment1_2);
        video1.AddComment(comment1_3);

        // Video 2
        Video video2 = new Video("Top 10 Best Dad Jokes (Professional Opinion)", "Bro. Godderidge", 900);

        Comment comment2_1 = new Comment("CSE210 Student 1", "ha ha!");
        Comment comment2_2 = new Comment("CSE210 Student 2", "tee hee!");
        Comment comment2_3 = new Comment("CSE210 Student 3", "C'est tres amusant.");

        video2.AddComment(comment2_1);
        video2.AddComment(comment2_2);
        video2.AddComment(comment2_3);

        // Video 3
        Video video3 = new Video("Proving That This Guy Gets It (Gone Wrong)", "Nick Rapp", 7200);

        Comment comment3_1 = new Comment("Certified Man of Great Knowledge", "With my great knowledge, I must say that this guy does, in fact, get it.");
        Comment comment3_2 = new Comment("Yet Another Guy", "I think I also get it.");
        Comment comment3_3 = new Comment("Yug", "I don't get it.");

        video3.AddComment(comment3_1);
        video3.AddComment(comment3_2);
        video3.AddComment(comment3_3);

        // Display everything
        List<Video> playlist = [video1, video2, video3];
        foreach (Video video in playlist)
        {
            video.DisplayVideo();
        }
        
    }        
}