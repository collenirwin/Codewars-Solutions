using System;

public static class Kata
{
  public static bool IsPrime(int n)
  {
    if (n < 2) return false;
    if (n == 2) return true;
    if (n % 2 == 0) return false;
    
    for (int x = 3; x <= Math.Sqrt(n); x += 2)
    {
      if (n % x == 0)
      {
        return false;
      }
    }
    
    return true;
  }
}