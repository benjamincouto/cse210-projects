using System.Collections.Concurrent;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word (string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
       if (_isHidden == false)
       {
        _isHidden = true;
       }

    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        if (_isHidden == false)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public string GetDisplayText()
    {
        if (_isHidden == false)
        {
            return _text;
        }
        else 
        {
            int letterCount = _text.Length;
            string underscores = new string('_', letterCount);

            return underscores;           

        }
        
    }

}