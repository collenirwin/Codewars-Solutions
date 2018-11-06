using System.Linq;

public class Kata
{
  public static string Remove(string s)
  {
    return s.Last() == '!' ? s.Substring(0, s.Length - 1) : s;
  }
}