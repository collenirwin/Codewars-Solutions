using System.Linq;

public class LargestTwo
{
  public static int[] TwoOldestAges(int[] ages)
  {
    return ages.OrderBy(x => x).Skip(ages.Length - 2).ToArray();
  }
}