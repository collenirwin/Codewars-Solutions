using System.Linq;

public class Kata
{
  public static int DuplicateCount(string str)
  {
    str = str.ToLower();
    return str.Distinct().Count(x => str.Count(y => x == y) > 1);
  }
}