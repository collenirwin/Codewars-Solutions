using System;

public class Sum
{
  public int GetSum(int a, int b)
  {
    int sum = 0;
    
    for (int x = Math.Min(a, b); x <= Math.Max(a, b); x++)
    {
      sum += x;
    }
    
    return sum;
  }
}