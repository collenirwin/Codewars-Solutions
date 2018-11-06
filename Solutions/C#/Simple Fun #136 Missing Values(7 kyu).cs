using System;
using System.Linq;

namespace myjinxin
{
  public class Kata
  {
    public int MissingValues(int[] arr)
    {
      int? once = null;
      int? twice = null;
      
      foreach (int num in arr)
      {
        if (arr.Count(x => x == num) == 1)
        {
          once = num;
        }
        else if (arr.Count(x => x == num) == 2)
        {
          twice = num;
        }
        
        if (once != null && twice != null)
        {
          break;
        }
      }
      
      return (int)(once * once * twice);
    }
  }
}