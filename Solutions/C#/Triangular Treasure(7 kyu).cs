using System;

public class Kata
{
  public static int Triangular(int n)
  {
    if (n < 2)
    {
      return Math.Max(0, n);
    }
    
    return (n * (n + 1)) / 2;
  }
}