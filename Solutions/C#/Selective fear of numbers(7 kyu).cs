using System;
using System.Collections.Generic;

public static class Kata
{
  static Dictionary<string, Func<int, bool>> dict 
    = new Dictionary<string, Func<int, bool>>()
  {
    { "Monday", (x) => x == 12 },
    { "Tuesday", (x) => x > 95 },
    { "Wednesday", (x) => x == 34 },
    { "Thursday", (x) => x == 0 },
    { "Friday", (x) => x % 2 == 0 },
    { "Saturday", (x) => x == 56 },
    { "Sunday", (x) => Math.Abs(x) == 666 }
  };

  public static bool AmIAfraid(string day, int num)
  {
    return dict[day](num);
  }
}