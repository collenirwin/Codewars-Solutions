using System.Linq;

public class Kata
{
  public static long SuperSize(long num)
  {
    return long.Parse(string.Join("", num.ToString().OrderByDescending(x => x)));
  }
}