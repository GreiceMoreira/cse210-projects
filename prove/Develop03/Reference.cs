using System.Security.Cryptography.X509Certificates;

public class Reference
{
    public string _book;
    public int _chapter;
    public int _verse;
    public int? _endVerse;

    public Reference(string book , int chapter , int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = null;

    }

    public Reference(string book , int chapter , int verse , int endVerse)
    {   
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        string myReference;

        if (_endVerse == null )
        {
            myReference =  _book +  " " + _chapter + ":" + _verse  ; 
        }
        else 
        {
            myReference =  _book + " " + _chapter + ":" + _verse + "-" + _endVerse ;
        }

        

        return myReference;
    }







}