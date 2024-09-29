
public class Entry
{   

    public string _dateText ;

    public string _promptText ;

    public string _entryText ;

    public void Display()
    {
        Console.WriteLine($"{_dateText} - Prompt: {_promptText} {_entryText}");
    }
}
