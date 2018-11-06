using System;
using System.Linq;

public static class Kata
{
  public static int SquareSum(int[] n)
  { 
    return n.Select(x => (int)Math.Pow(x, 2)).Sum();
  }
}