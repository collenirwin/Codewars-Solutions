using System.Linq;

public class Digits
{
  public static string Explode(string s)
  {
    return string.Join("", s.Select(x => new string(x, int.Parse(x.ToString()))));
  }
}