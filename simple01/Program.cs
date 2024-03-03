// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello, World!");

    string quote = "In coming days, it will not be possible to survive spiritually without the guiding, directing, comforting, and constant influence of the Holy Ghost.";

    string run_again = "yes";

    while (run_again.ToLower() == "yes")
    {
      Console.Write("What is your favorite number?: ");
      int num = int.Parse(Console.ReadLine());

      StringBuilder result = new StringBuilder();
      foreach (char letter in quote)
      {
        if (result.Length % num == 0)
        {
          result.Append(char.ToUpper(letter));
        }
        else
        {
          result.Append(letter);
        }
      }
      // Console.WriteLine(quote);
      Console.WriteLine(result.ToString());
      Console.Write("Do you want to run again?: ");
      run_again = Console.ReadLine();
    }
  }
}