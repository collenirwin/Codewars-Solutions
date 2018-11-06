using System;

public static class Kata
{
  public static string Sentencify(string[] words)
  {
    string s = string.Join(" ", words);
    return s.Substring(0, 1).ToUpper() + s.Substring(1) + ".";
  }
}