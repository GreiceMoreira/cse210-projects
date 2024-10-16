
public class MathAssignment : Assignment
{
//A Math assignment may need to store the student's name, the topic (for example, "Fractions"), the textbook section (for example, "7.3"), and the problems from that section (for example, "3-10, 20-21").

    private string _textbookSelection;
    private string _problems;

//The Math assignment should have a constructor that requires a value for each of the items that it stores.
    public MathAssignment(string studentName, string topic, string textbook, string problems) : base(studentName , topic)
    {
        _textbookSelection = textbook;
        _problems = problems;
    }


//The Math assignment needs to provide a method to return a summary of the assignment that contains 
//the student's name and the topic, and it also needs to provide a method to display the Math homework 
//list including the section number and the problems (for example, "Section 7.3 Problems 8-19").
    
    public string GetHomeworkList()
    {
        return $"{GetSummary()} \n Section {_textbookSelection} Problems {_problems}";
    }









}