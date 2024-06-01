public class Comment
{
    private string _name;
    private string _text;
    private float _likes;
    public Comment(string name, string text, float likes)
    {
        _name = name;
        _text = text;
        _likes = likes;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"{_name} - {_text} - {_likes} likes");
    }
}