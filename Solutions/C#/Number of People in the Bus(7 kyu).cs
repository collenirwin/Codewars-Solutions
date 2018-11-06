using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int Number(List<int[]> peopleListInOut)
  {
    return peopleListInOut.Aggregate(0, (t, x) => t + x[0] - x[1]);
  }
}