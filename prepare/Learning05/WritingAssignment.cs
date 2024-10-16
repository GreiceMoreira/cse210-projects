


public class WrittingAssignemnt : Assignment

//A writing assignment may need to store the student's name, the topic (for example, "European History"),
// and the title of the assignment (for example, "The Causes of World War II").
{
    private string _title;

//The writing assignment should have a constructor that requires a value for each of the items that it stores.

    public WrittingAssignemnt(string studentName, string topic , string title) : base(studentName , topic)
    {
        _title = title;

    }

    public string GetTitle()
    {
        return _title;
    }

    public void SetTite(string title)
    {
        _title = title;
    }


//The writing assignment needs to provide a method to return a summary of the assignment that contains 
//the student's name and the topic, and it also needs to provide a method to get the writing information
//which consists of the title and the student's name (for example, "The Causes of World War II by Mary Waters").

    public string GetWritingInformation()
    {
        return $"{GetSummary()} \n {_title} by {_studentName}";
    }




}