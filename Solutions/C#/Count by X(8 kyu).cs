using System.Linq;

public static class Kata
{
  public static int[] CountBy(int x, int n)
  {
    return Enumerable.Range(1, n).Select(i => i * x).ToArray();
  }
}