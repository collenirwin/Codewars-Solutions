using System;
using System.Linq;

public static class Kata
{
  public static int DescendingOrder(int num)
  {
    return int.Parse(string.Join("", num.ToString().OrderByDescending(x => x)));
  }
}