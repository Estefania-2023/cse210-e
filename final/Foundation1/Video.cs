using System;
public class Video 
{
    private string _title;
    private string _author;
    private double _length;
    private int _likes;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, double length, int likes)
    {
        _title = title;
        _author = author;
        _length = length;
        _likes = likes;
    }
    public void ListComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int CountComments()
    {
        int count = 0;
        count = _comments.Count;
        return count;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title} | Author: {_author} | Length: {_length} seconds | Likes: {_likes} likes");
        Console.WriteLine();
        int commentCount = CountComments();
        Console.WriteLine($"Number of comments: {commentCount}");
        foreach (Comment comment in _comments)
        {
            comment.DisplayInfo();
        }    
    }
}
