using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Anagram.Models;
using System;

namespace Anagram.Tests
{
  [TestClass]
  public class WordTests
  {
    [TestMethod]
    public void WordConstructor_CreatesInstanceOfWord_Word()
    {
      List<string> words = new List<string> {};
      words.Add("beard");
      Word word = new Word("bread", words);

      Assert.AreEqual(typeof(Word), word.GetType());
    }

    [TestMethod]
    public void WordConstructor_ReturnsWord_String()
    {
      string myWord = "bread";
      List<string> words = new List<string> {};
      words.Add("beard");
      Word word = new Word(myWord, words);

      string result = word.InputWord;

      Assert.AreEqual(myWord, result);
    }

    [TestMethod]
    public void WordConstructor_ReturnsList_List()
    {
      List<string> words = new List<string> {};
      words.Add("beard");
      Word word = new Word("bread", words);

      Assert.AreEqual(words, word.PossibleAnagrams);
    }

    [TestMethod]
    public void WordToCharArray_ReturnsArray_Array()
    {
      //Arrange
      List<string> words = new List<string> {};
      words.Add("bread");
      Word inputWord = new Word("bread", words);
      string myWord = "bread";
      
      //Act
      char[] charArray = myWord.ToCharArray();
      char[] myCharArray = inputWord.WordToCharArray();

      //Assert
      CollectionAssert.AreEqual(charArray, myCharArray);
    }

    [TestMethod]
    public void WordListToCharArrays_ReturnsList_List()
    {
      //Arrange

      //Act

      //Assert
    }

  }
}