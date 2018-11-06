using System.Linq;
using System.Text.RegularExpressions;

public class Kata
{
  public static string[] GetUserIds(string s)
  {
    return Regex.Split(s
      .Replace("#", "")
      .ToLower()
      .Trim(), @",\s+")
        .Select(x => x.StartsWith("uid") ? x.Substring(3) : x)
        .ToArray();
  }
}