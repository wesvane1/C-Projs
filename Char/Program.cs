// See https://aka.ms/new-console-template for more information
using System;

class Program
{
  static void Main()
  {
    string sentence = "haveaniceday";
    string result = removeVowels(sentence);

    Console.WriteLine(result);

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