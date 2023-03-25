using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of YouTube videos
        List<YouTubeVideo> videos = new List<YouTubeVideo>();

        // Create the first video
        YouTubeVideo video1 = new YouTubeVideo();
        video1.Title = "Video 1";
        video1.Author = "Author 1";
        video1.Length = 120;
        video1.AddComment("Commenter 1", "This is the first comment.");
        video1.AddComment("Commenter 2", "This is the second comment.");
        video1.AddComment("Commenter 3", "This is the third comment.");
        videos.Add(video1);

        // Create the second video
        YouTubeVideo video2 = new YouTubeVideo();
        video2.Title = "Video 2";
        video2.Author = "Author 2";
        video2.Length = 180;
        video2.AddComment("Commenter 1", "This is the first comment.");
        video2.AddComment("Commenter 2", "This is the second comment.");
        videos.Add(video2);

        // Create the third video
        YouTubeVideo video3 = new YouTubeVideo();
        video3.Title = "Video 3";
        video3.Author = "Author 3";
        video3.Length = 240;
        video3.AddComment("Commenter 1", "This is the first comment.");
        video3.AddComment("Commenter 2", "This is the second comment.");
        video3.AddComment("Commenter 3", "This is the third comment.");
        video3.AddComment("Commenter 4", "This is the fourth comment.");
        videos.Add(video3);

        // Iterate through the list of videos and display their details and comments
        foreach (YouTubeVideo video in videos)
        {
            video.DisplayDetails();
        }
    }
}
