using System;
using System.Collections.Generic;

// Abstract class for a video
abstract class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    private List<Comment> comments = new List<Comment>(); // list to store comments

    // Method to add a comment to the video
    public void AddComment(string name, string text)
    {
        Comment comment = new Comment(name, text);
        comments.Add(comment);
    }

    // Method to get the number of comments for the video
    public int GetCommentCount()
    {
        return comments.Count;
    }

    // Method to display the video details and comments
    public void DisplayDetails()
    {
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Length (in seconds): " + Length);
        Console.WriteLine("Number of comments: " + GetCommentCount());
        Console.WriteLine("Comments:");

        foreach (Comment comment in comments)
        {
            Console.WriteLine(comment.Name + ": " + comment.Text);
        }

        Console.WriteLine();
    }
}