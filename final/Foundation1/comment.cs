public class Comment
{
    public string _name;
    public string _comment;



    public void DisplayComment()
    {
        Console.WriteLine($"{_name}:{_comment}");
    }
}