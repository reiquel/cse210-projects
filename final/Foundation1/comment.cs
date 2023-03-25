using System;
using System.Collections.Generic;
// Class for a comment
class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}

// Class for a YouTube video that extends the Video abstract class
class YouTubeVideo : Video
{
}
  