using System.Text.RegularExpressions;
using System.Linq;

public static class Kata
{
  public static string ReverseWords(string str)
  {
    var matches = Regex.Matches(str, @"\S+");

    foreach (Match match in matches)
    {
      str = str
        .Remove(match.Index, match.Length)
        .Insert(match.Index, string.Join("", match.Value.Reverse()));
    }

    return str;
  }
}