using System.Linq;
using System.Collections.Generic;

public class Deadfish
{
  public static int[] Parse(string data)
  {
    int val = 0;
    var list = new List<int>();
    
    foreach (char c in data)
    {
      if (c == 'i')
      {
        val++;
      }
      else if (c == 'd')
      {
        val--;
      }
      else if (c == 's')
      {
        val *= val;
      }
      else if (c == 'o')
      {
        list.Add(val);
      }
    }
    
    return list.ToArray();
  }
}