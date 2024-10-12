//Your program should have a class for a Video that has the responsibility
// to track the title, author, and length (in seconds) of the video. 
//Each video also has responsibility to store a list of comments, and should have a method to return the number of comments. 

public class Video
{
    private string _title;
    private string _author;
    private int _length; //in seconds
    private List<Comment> _videoComments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length * 60;
    }
    public void AddInListOfComments(Comment comment)
    {
        _videoComments.Add(comment);
    }

    public List<Comment> GetComments()
    {
        return _videoComments;
    }
    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLength()
    {
        return _length;
    }

    public int NumberOfComments()
    {

        return _videoComments.Count;

    }













}