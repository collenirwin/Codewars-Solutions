using System.Text.RegularExpressions;

public class Kata
{
  public static string Shortcut(string input)
  {
    return Regex.Replace(input, "[aeiou]", "");
  }
}