using System;
using System.Text.RegularExpressions;

public class Kata
{
  public static string filterWords(string phrase)
  {
      string pattern = @"bad|mean|ugly|horrible|hideous\b";
      string replacement = "awesome";
      return Regex.Replace(phrase, pattern, replacement, RegexOptions.IgnoreCase);
  }
}