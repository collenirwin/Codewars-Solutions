using System.Collections.Generic;
using System.Linq;

public class Xbonacci
{
  public double[] Tribonacci(double[] signature, int n)
  {
    if (n == 0)
    {
      return new double[1];
    }
    
    var list = new List<double>(signature);
    for (int x = 0; x < n - signature.Length; x++)
    {
      int c = list.Count - 1;
      list.Add(list[c] + list[c - 1] + list[c - 2]);
    }
    
    return list.Take(n).ToArray();
  }
}