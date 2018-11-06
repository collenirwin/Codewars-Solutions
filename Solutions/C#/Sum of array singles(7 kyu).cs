using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  public static int Repeats(List<int> source)
  {
    return source.Where(x => source.Count(y => y == x) == 1).Sum();
  }
}