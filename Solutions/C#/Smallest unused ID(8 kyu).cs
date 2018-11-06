using System.Linq;

public class Kata
{
  public static int NextId(int[] ids)
  {
    var sorted = ids.OrderBy(x => x).ToArray();
    
    for (int x = 0; x < sorted.Length; x++)
    {
      if (sorted[x] != x)
      {
        return x;
      }
    }
    
    return sorted.Last() + 1;
  }
}