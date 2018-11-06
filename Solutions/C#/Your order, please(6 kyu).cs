using System.Linq;
using System.Text.RegularExpressions;

public static class Kata
{
  public static string Order(string words)
  {
    return string.Join(" ", words
      .Split(' ')
      .OrderBy(x => Regex.Match(x, @"\d+").Value));
  }
}