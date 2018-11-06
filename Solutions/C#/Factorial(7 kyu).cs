using System;

public static class Kata
{
  public static int Factorial(int n)
  {
    if (n < 0 || n > 12)
    {
      throw new ArgumentOutOfRangeException("n must be between 0 and 12");
    }
    
    if (n < 2)
    {
      return 1;
    }
    
    return n * Factorial(n - 1);
  }
}