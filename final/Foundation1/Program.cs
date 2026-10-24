using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to Build a Gaming PC", "TechGuy", 620);
        video1.AddComment(new Comment("Alex", "This tutorial was really helpful!"));
        video1.AddComment(new Comment("Sarah", "Great explanation of the parts."));
        video1.AddComment(new Comment("Mike", "I built my first PC using this."));
        video1.AddComment(new Comment("Jordan", "Can you make a budget PC video?"));

        Video video2 = new Video("Best Hiking Trails", "OutdoorLife", 480);
        video2.AddComment(new Comment("Emily", "These trails look amazing."));
        video2.AddComment(new Comment("Chris", "I want to visit that first trail."));
        video2.AddComment(new Comment("Taylor", "Thanks for the recommendations!"));
        video2.AddComment(new Comment("Sam", "Great video and scenery."));

        Video video3 = new Video("Easy Pasta Recipe", "CookingWithJen", 355);
        video3.AddComment(new Comment("Olivia", "I made this for dinner."));
        video3.AddComment(new Comment("Noah", "Looks delicious!"));
        video3.AddComment(new Comment("Emma", "I added extra cheese."));
        video3.AddComment(new Comment("Liam", "Please share more recipes."));

        Video video4 = new Video("Beginner Photography Tips", "PhotoPro", 540);
        video4.AddComment(new Comment("Ava", "These tips helped me a lot."));
        video4.AddComment(new Comment("Ethan", "What camera do you recommend?"));
        video4.AddComment(new Comment("Mia", "The lighting tip was great."));
        video4.AddComment(new Comment("Lucas", "Thanks for sharing!"));

        List<Video> videos = new List<Video>
        {
            video1, video2, video3, video4
        };

        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()}");
            Console.WriteLine($"number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetName()}: {comment.GetText()}");
            }
            Console.WriteLine();
        }
    }
}