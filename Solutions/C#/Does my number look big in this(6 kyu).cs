using System;
using System.Linq;

public class Kata
{
  public static bool Narcissistic(int val)
  {
    string vs = val.ToString();
    return val == vs.Sum(x => Math.Pow(int.Parse(x.ToString()), vs.Length));
  }
}