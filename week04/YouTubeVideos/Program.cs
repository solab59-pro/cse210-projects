class Program
{
    static void Main(string[] args)
    {
        // Create videos
        var video1 = new Video("Learn C# in 10 Minutes", "CodeAcademy", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks."));
        video1.AddComment(new Comment("Charlie", "Please make one on LINQ."));

        var video2 = new Video("Advanced Unity Tips", "GameDevPro", 1200);
        video2.AddComment(new Comment("Dave", "Wow, I didn't know about the profiler!"));
        video2.AddComment(new Comment("Emma", "Awesome content as always."));
        video2.AddComment(new Comment("Frank", "Can you do a series on shaders?"));

        var video3 = new Video("History of the Internet", "NetNerd", 900);
        video3.AddComment(new Comment("Grace", "Super informative."));
        video3.AddComment(new Comment("Hannah", "Nice animations."));
        video3.AddComment(new Comment("Ian", "Loved the part about ARPANET!"));

        var video4 = new Video("Daily Workout Routine", "FitLife", 480);
        video4.AddComment(new Comment("Jack", "Burned 300 calories, yay!"));
        video4.AddComment(new Comment("Kelly", "Perfect for busy mornings."));
        video4.AddComment(new Comment("Liam", "Subscribed!"));

        // Add videos to list
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // Display video info and comments
        foreach (var video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length (seconds): " + video.LengthInSeconds);
            Console.WriteLine("Number of comments: " + video.GetCommentCount());

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine(new string('-', 40));
        }
    }
}
