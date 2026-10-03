using System;
using System.Collections.Concurrent;
using System.ComponentModel;

public class ScriptureRef
{
    private string _bName;
    private int _chapter;
    private int _fVerse;
    private int _lVerse;

    public ScriptureRef(string book, int chapter, int verse)
    {
        _bName = book;
        _chapter = chapter;
        _fVerse = verse;
        _lVerse = verse;
    }

    public ScriptureRef(string book, int chapter, int fverse, int lverse)
    {
        _bName = book;
        _chapter = chapter;
        _fVerse = fverse;
        _lVerse = lverse;
    }

    public string GetText()
    {
        if (_fVerse == _lVerse)
        {
            return $"{_bName} {_chapter}:{_fVerse}";
        } else
        {
            return $"{_bName} {_chapter}:{_fVerse}-{_lVerse}";
        }
    }
}