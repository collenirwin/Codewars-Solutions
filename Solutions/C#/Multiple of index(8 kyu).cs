using System.Linq;
using System.Collections.Generic;

public static class Kata
{
  public static List<int> MultipleOfIndex(List<int> xs)
  {
    int index = 1;
    return xs.Skip(1).Where(x => x % index++ == 0).ToList();
  }
}