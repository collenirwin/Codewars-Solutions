using System;

public class Kata
{
  public static int Remainder(int a, int b)
  {
    return Math.Max(a, b) % Math.Min(a, b);
  }
}