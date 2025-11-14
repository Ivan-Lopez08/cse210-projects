public class Words
{
    private string _text;
    private bool _isHidden;

    public Words(string text)
    {
        _text = text;
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

    public string GetDisplayWord()
    {
        string textToPrint = "";

        bool isNumber = int.TryParse(_text, out int num);

        if (_isHidden && !isNumber)
        {
            
            for ( int i = 0; i < _text.Length; i++)
            {
                string specialCharacters = ",./!@#$%^&*()_+=-[]{}:;\"'<>?";
                if (specialCharacters.Contains(_text[i]))
                {
                    textToPrint += _text[i];
                }
                else
                {
                    textToPrint += "_";
                } 
            }
        }
        else
        {
            textToPrint = _text;
        }

        return textToPrint;
    }


}