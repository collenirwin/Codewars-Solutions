using System.Linq;

public static class MonkeyCounter
{
  public static int[] MonkeyCount(int n)
  {
    return Enumerable.Range(1, n).ToArray();
  }
}