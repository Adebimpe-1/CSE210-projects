using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Requirement #1: Create 3+ Video objects with values
        Video video1 = new Video("Intro to OOP in C#", "Jane Doe", 600);
        Video video2 = new Video("Design Patterns Overview", "Ade Ade", 900);
        Video video3 = new Video("Abstraction Explained", "John Smith", 720);

        // Requirement #1: 3+ Comments per Video
        video1.AddComment(new Comment("Daniel", "Great introduction, thanks!"));
        video1.AddComment(new Comment("Emma", "Very clear explanation."));
        video1.AddComment(new Comment("Felix", "Please make a follow-up video."));

        video2.AddComment(new Comment("Grace", "This helped me prepare for my exam."));
        video2.AddComment(new Comment("Henry", "Can you cover more examples?"));
        video2.AddComment(new Comment("Isabella", "Loved the UML section."));
        video2.AddComment(new Comment("James", "Subscribed to your channel."));

        video3.AddComment(new Comment("Karen", "Abstraction finally makes sense."));
        video3.AddComment(new Comment("Leo", "Short and straight to the point."));
        video3.AddComment(new Comment("Maria", "I will share this with my classmates."));

        // Requirement #1: Store in List
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Requirement #2: Iterate and display all info
        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}
