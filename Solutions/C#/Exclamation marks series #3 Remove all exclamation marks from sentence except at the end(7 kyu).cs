using System.Text.RegularExpressions;

public class Kata
{
  public static string Remove(string s)
  {
    var match = Regex.Match(s, @"!+$");
    
    return s.Replace("!", "") + match.Value;
  }
}