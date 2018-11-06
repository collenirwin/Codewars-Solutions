using System;
using System.Text.RegularExpressions;

public static class Kata
{
  public static bool Vowel(this string s)
  {
    return s.Length == 1 && Regex.IsMatch(s, "^[aeiou]$", RegexOptions.IgnoreCase);
  }
}