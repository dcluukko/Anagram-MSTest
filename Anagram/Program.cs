using Anagram.Models;
using System;
using System.Collections.Generic;

namespace Anagram
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a Word :");
      string userInputWord = Console.ReadLine();
      List<string> possibleAnagrams = EnterPossibleAnagrams(userInputWord);
      Word userWord = new Word(userInputWord, possibleAnagrams);
      DisplayAnagrams(userWord);
    }

    public static List<string> EnterPossibleAnagrams(string userInputWord)
    {
      Console.WriteLine("Enter possible anagrams for" + userInputWord + " seperated by a space:");
      string userInputPossibleAnagram = Console.ReadLine();
      List<string> listOfAnagramOptions = new List<string> {};

      string[] arrayOfOptions = userInputPossibleAnagram.Split(" ");

      foreach (string item in arrayOfOptions)
      {
        listOfAnagramOptions.Add(item);
      }
      return listOfAnagramOptions;
    }

    public static void DisplayAnagrams(Word userWord)
    {
      char[] userWordArray = userWord.WordToCharArray();
      List<char[]> possibleAnagramList = userWord.WordListToCharArrays();

      userWord.IsWordAnagram(userWordArray, possibleAnagramList);

      List<string> actualAnagrams = userWord.ActualAnagrams;if (actualAnagrams.Count == 0)
      {
        Console.WriteLine("No anagrams here!");
      }
      else
      {
        Console.WriteLine("The following are anagrams: ");
        foreach (string anagram in actualAnagrams)
        {
          Console.WriteLine(anagram);
        }
      }
    }
  }
}