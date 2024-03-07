using System;

class IsString
{
  public static bool checkString(string input)
  {
    foreach (char c in input)
  {
    if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
    {
      return false;
    }
  }
  return true;
  }
}