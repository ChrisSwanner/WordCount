using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class CountWords_FindTwoWordsInStringDespiteCaps_2
  {
    [TestMethod]
    public void CountWords_FindTwoWordsInString_2()
    {
      Assert.AreEqual(2, WordModel.CountWords("apple", "this here apple sure is a tasty apple"));
    }
    [TestMethod]
    public void CountWords_FindTwoWordsInStringDespiteSpace_1()
    {
        Assert.AreEqual(1, WordModel.CountWords("apple", "today is a nice apple"));
    }
    [TestMethod]
    public void wordCount_FindTwoWordsInStringDespiteCaps_2()
    {
        Assert.AreEqual(2, WordModel.CountWords("Apple", "this apple is a nice apple"));
    }
  }

}
