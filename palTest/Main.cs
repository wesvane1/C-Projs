using System;

class Program
{
  static void Main(string[] args)
  {
    Console.Write("Enter a word to check: ");
    string test = Console.ReadLine();
    string half1 = "";
    string half2 = "";
    int length = test.Length;
    // The first half of letters
    for (int i = 0; i < (length+1)/2; i++)
    {
      // Console.WriteLine(test[i]);
      half1 += test[i];
    };
    // The second half of letters
    for (int j = length-1; j >= (length-1)/2; j--)
    {
      // Console.WriteLine(test[j]);
      half2 += test[j];
    };
    if (half1 == half2)
    {
      Console.WriteLine("Palindrome!");
      Console.WriteLine($"The word that is repeated is: {test.Substring(0, (length+1)/2)}");
    }
    else{
      Console.WriteLine("Not Palindrome");
    }
  }
}