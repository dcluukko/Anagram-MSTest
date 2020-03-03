using System;
using System.Collections.Generic;

namespace Anagram.Models
{
  public class Word
  {
    public string InputWord { get; set; }
    public List<string> PossibleAnagrams { get; } = new List<string> {};

    public Word(string inputWord, List<string> possibleAnagrams)
    {
      InputWord = inputWord;
      PossibleAnagrams = possibleAnagrams;
    }

    public char[] WordToCharArray()
    {
      char[] inputWordArray = InputWord.ToCharArray();
      return inputWordArray;
    }

    public List<char[]> WordListToCharArrays()
    {
      List<char[]> exampleList = new List<char[]> {};
      char[] example = { 'e' };
      exampleList.Add(example);
      return exampleList;
    }
  }
}