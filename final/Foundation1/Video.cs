public class Video
{
    private string _title;
    private string _author;
    private int _length;

    private List<Comment> _comments = new List<Comment>();

    public void DisplayVideo()
    {
        Console.WriteLine($"title:{_title}");
        Console.WriteLine($"title:{_author}");
        Console.WriteLine($"title:{_length}");
    }

}