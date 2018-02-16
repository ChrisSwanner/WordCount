using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WordCounter.Models
{
  public class WordModel
  {
    private string _searchWord;
    private string _phrase;
    private int _count;

    public WordModel(string searchWord, string phrase, int count)
    {
      _searchWord = searchWord;
      _phrase = phrase;
      _count = count;
    }

    public string GetSearchWord()
    {
      return _searchWord;
    }
    public string GetPhrase()
    {
      return _phrase;
    }
    public int GetCount()
    {
      return _count;
    }
    private static char[] _possibleSplits = {' ', ',', '.',':','-','_'
    };

    public static int CountWords(string searchWord, string phrase)
    {
      string[] splitPhrase = phrase.Split(_possibleSplits);
      int count = 0;
      foreach (var word in splitPhrase)
      {
        if (word.ToLower() == searchWord.ToLower())
        {
          count++;
        }
      }
      return count;
    }
  }
}
