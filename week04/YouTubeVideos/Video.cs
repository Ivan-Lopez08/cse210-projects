using System.Runtime.CompilerServices;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comments> _comments = new List<Comments>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void addComment(string author, string text)
    {
        Comments comment = new Comments(author, text);
        _comments.Add(comment);
    }

    public int getNumberOfComments()
    {
        return _comments.Count();
    }

    public void displayVideoInfo()
    {
        Console.WriteLine($"\nVideo Title: {_title}.");
        Console.WriteLine($"Video Author: {_author}");
        Console.WriteLine($"Video duration in seconds: {_length}");
        Console.WriteLine($"Number of comments: {getNumberOfComments()}");
        Console.WriteLine("Comments: ");

        if (_comments.Count() == 0)
        {
            Console.WriteLine("No comments yet.");
        }
        else
        {
            int counter = 1;
            foreach (Comments comment in _comments)
            {
                Console.WriteLine($"Comment #{counter}");
                comment.displayComments();
                counter ++;
            }
        }
    }
}