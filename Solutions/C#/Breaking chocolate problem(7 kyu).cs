using System;

public class Kata 
{
  public static int BreakChocolate(int n, int m) 
  {
    if (Math.Min(n, m) < 1)
    {
      return 0;
    }
    
    return n * m - 1;
  }
}