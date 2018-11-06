using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static int Find(int[] integers)
  {
    int odd = 0;
    int even = 0;
    
    for (int x = 0; x < 3; x++)
    {
      if (integers[x] % 2 == 0)
      {
        even++;
      }
      else
      {
        odd++;
      }
    }
    
    int rem = (odd > even) ? 0 : 1;
    
    foreach (int num in integers)
    {
      if (num % 2 == rem)
      {
        return num;
      }
    }
    
    return -1;
  }
}