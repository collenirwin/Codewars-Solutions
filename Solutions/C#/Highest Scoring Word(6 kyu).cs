using System.Linq;
using System.Text.RegularExpressions;

public class Kata
{
  const string ALPHA = "abcdefghijklmnopqrstuvwxyz";

  public static string High(string s)
  {
    return Regex.Split(s, @"\s+")
      .OrderByDescending(x => x
        .Aggregate(0, (t, y) => t + ALPHA.IndexOf(y)))
      .ToArray()
      .First();
  }
}