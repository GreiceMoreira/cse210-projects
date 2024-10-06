using System.Reflection.Metadata.Ecma335;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;

    }

    public string GetDisplayText()
    {
        string aWord = "";
        if (_isHidden)
        {
            char[] strArray = _text.ToCharArray();

            foreach (var item in strArray)
            {

                if (char.IsLetter(item))
                {
                    aWord += "_";
                }
                else {
                    aWord += item;
                }
            }
        }
        else
        {
            aWord = _text;
        }

        return aWord;

    }



}