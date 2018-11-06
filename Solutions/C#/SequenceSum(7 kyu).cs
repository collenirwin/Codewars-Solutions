using System;
using System.Linq;

public class SequenceSum
{
	public static int[] SumOfN(int n)
	{
    int negator = n < 0 ? -1 : 1;
    var range = Enumerable.Range(0, Math.Abs(n) + 1);
  
    return range
      .Select((x, i) => range.Take(i + 1).Sum() * negator)
      .ToArray();
	}
}