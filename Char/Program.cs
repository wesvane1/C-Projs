// See https://aka.ms/new-console-template for more information
using System;

class Program
{
  static void Main()
  {
    string sentence = "haveaniceday";
    string result = removeVowels(sentence);

    Console.WriteLine(result);

    // string word = Console.Write("What is your favorite word?")

    // foreach (var letter in vowels)
    // {
    //   Console.WriteLine(letter);
    // }
  }

  static string removeVowels(string sentence)
  {
    string vowels = "aeiouAEIOU";
    string result = "";

    foreach(var letter in sentence)
    {
      if (!vowels.Contains(letter))
      {
        result += letter;
      }
    }
    return result;
  }
}