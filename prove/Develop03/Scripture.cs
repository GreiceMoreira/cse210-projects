public class Scripture
{
    private Reference _reference;
    private List<Word> _scriptureText = new List<Word>();

    private void CreateList(string scriptureText)
    {
        string[]words = scriptureText.Split(' ');

        foreach (string word in words)
        {
            _scriptureText.Add(new Word(word));
        }
    }

    public Scripture(Reference refDoComstrutor , string text)
    {
        _reference = refDoComstrutor;
        CreateList(text);
    }
    
    public void HideRandomWords(int numberToHide)
    {
        var random = new Random();

        int countHiddenWords = 0;

        while (!IsCompletelyHidden() && countHiddenWords < numberToHide) {

            int index = random.Next(_scriptureText.Count);
            if (!_scriptureText[index].IsHidden()) {
                _scriptureText[index].Hide();
                countHiddenWords++;
            }
        }

    }

    public string  GetDisplayText()
    {
        string text = _reference.GetDisplayText() + " ";
        foreach(Word word in _scriptureText) {
            text += " " + word.GetDisplayText();
        }
        return text;
    }


    public bool IsCompletelyHidden()
    {
        bool allWordsAreHidden = true;

        foreach(Word word in _scriptureText) {
            if (!word.IsHidden()) {
                allWordsAreHidden = false;
            }
        }

        return allWordsAreHidden;
    }












}