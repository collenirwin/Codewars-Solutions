using System;
using System.Linq;

public class Kata
{
  public int ReverseNumber(int n)
  {
    string sign = n < 0 ? "-" : "";
    return int.Parse(sign + string.Join("", Math.Abs(n).ToString().Reverse()));
  }
}