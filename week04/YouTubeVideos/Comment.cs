public class Comments
{
    private string _author;
    private string _comment;

    public Comments(string author, string comment)
    {
        _author = author;
        _comment = comment;
    }

    public void displayComments()
    {
        Console.WriteLine($"Comment by: {_author}");
        Console.WriteLine(_comment);
    }

}