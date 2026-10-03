using System;
using System.Collections.Generic;

public class Words
{
    private string _text;
    private bool _hidden;

    public Words(string text)
    {
        _text = text;
        _hidden = false;
    }

    public void Hide()
    {
        _hidden = true;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public string GetText()
    {
        if (_hidden)
        {
            return "_____";
        }
        else
        {
            return _text;
        }
    }
}

class Scripture
{
    private ScriptureRef _reference;
    private List<Words> _words;

    public Scripture(ScriptureRef refernce, string text)
    {
        _reference = refernce;
        _words = new List<Words>();

        string[] words = text.Split(' ');

        foreach (string word in words)
        {
            _words.Add(new Words(word));
        }
    }

    public string GetText()
    {
        string result = _reference.GetText() + "\n";

        foreach (Words words in _words)
        {
            result += words.GetText() + " ";
        }

        return result.Trim();
    }

    public void HideWords(int numberToHide)
    {
        Random random = new Random();

        for (int i=0; i < numberToHide; i++)
        {
            int index = random.Next(_words.Count);

            _words[index].Hide();
        }
    }

    public bool IscompletelyHidden()
    {
        foreach(Words words in _words)
        {
            if (!words.IsHidden())
            {
                return false;
            }
        }

        return true;
    }

}