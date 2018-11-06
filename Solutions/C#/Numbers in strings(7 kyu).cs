using System.Linq;
using System.Text.RegularExpressions;

public static class Kata
{
  public static int Solve(string s)
  {
    return Regex.Matches(s, @"\d+")
      .OfType<Match>()
      .Select(x => int.Parse(x.Value))
      .Max();
  }
}