using System.Linq;

public static class Kata
{
  public static int[] digitize(int n)
  {
    return n.ToString()
      .Select(x => int.Parse(x.ToString()))
      .ToArray();
  }
}