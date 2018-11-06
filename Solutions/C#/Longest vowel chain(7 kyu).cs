using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class Kata
{
  public static int Solve(string str)
  {
    if (str == null)
    {
      throw new ArgumentNullException();
    }
    
    var matches = Regex.Matches(str, "[aeiou]+").OfType<Match>();
    
    return matches.Any()
      ? matches.Select(x => x.Value.Length).Max()
      : 0;
  }
}