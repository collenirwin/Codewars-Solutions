using System.Linq;

public static class Kata
{
  public static string Solve(string a, string b)
  {
    return string.Join("", a.Where(x => !b.Contains(x)).Concat(b.Where(x => !a.Contains(x))));
  }
}