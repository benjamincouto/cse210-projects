public class Video 
{
    private string _title;
    private string _author;
    private float _length;
    private List<Comment> _comments = new List<Comment>();

    public Video (string title, string author, float length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void StoreComment(String commenterName, String commentText) 
    {
        Comment comment = new Comment(commenterName, commentText);
        _comments.Add(comment);
    }

    public int CountComments()
    {
        int commentsCount = _comments.Count();

        return commentsCount;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("_____________________________________________________________");
        Console.WriteLine();
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length}");
        Console.WriteLine($"Comments count: {CountComments()}");
        Console.WriteLine("Comments: ");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"User: {comment.GetName()}");
            Console.WriteLine($"Comment: {comment.GetText()}");
            Console.WriteLine();
        }


    }

}
