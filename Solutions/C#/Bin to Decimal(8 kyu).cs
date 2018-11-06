using System;
using System.Linq;

namespace Solution
{
  public static class Program
  {
    public static int binToDec(string s)
    {
      return (int)s
        .Select((x, i) => int.Parse(x.ToString()) * Math.Pow(2, s.Length - i - 1))
        .Sum();
    }
  }
}