using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int[] Divisors(int n)
  {
    var list = new List<int>();
    
    for (int x = 2; x <= Math.Sqrt(n); x++)
    {
      if (n % x == 0)
      {
        if (n / x == x)
        {
          list.Add(x);
        }
        else
        {
          list.Add(x);
          list.Add(n / x);
        }
      }
    }
    
    return list.Count != 0 ? list.OrderBy(x => x).ToArray() : null;
  }
}