using System;

public class Kata
{
  public static bool IsSquare(int n)
  {
    double sqrt = Math.Sqrt(n);
    return sqrt == (long)sqrt;
  }
}