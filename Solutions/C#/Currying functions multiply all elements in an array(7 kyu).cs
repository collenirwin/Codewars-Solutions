using System;
using System.Linq;

public static class Kata
{
  public static Func<int, int[]> MultiplyAll(int[] array)
  {
    return (i) => array.Select(x => x * i).ToArray();
  }
}