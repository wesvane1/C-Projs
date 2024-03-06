using System;

class Program
{
  static void Main(string[] args)
  {
    List<int> myList = new List<int> {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
    foreach (int number in myList)
    {
      if (IsPrime.CheckPrime(number))
      {
        Console.WriteLine($"{number} is prime!");
      }      
    }
  }
}