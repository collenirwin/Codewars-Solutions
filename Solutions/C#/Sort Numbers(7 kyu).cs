using System.Linq;

public class Kata
{
  public static int[] SortNumbers(int[] nums)
  {
    return nums?.OrderBy(x => x).ToArray() ?? new int[0];
  }
}