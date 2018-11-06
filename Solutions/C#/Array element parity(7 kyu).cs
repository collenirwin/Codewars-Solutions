using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  public static int Solve(List<int> arr)
  {
    return arr.First(x => !arr.Any(y => y == -x));
  }
}