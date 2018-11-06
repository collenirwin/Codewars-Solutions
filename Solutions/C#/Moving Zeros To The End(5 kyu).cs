using System.Linq;

public class Kata
{
  public static int[] MoveZeroes(int[] arr)
  {
    return arr.Where(x => x != 0).Concat(arr.Where(x => x == 0)).ToArray();
  }
}