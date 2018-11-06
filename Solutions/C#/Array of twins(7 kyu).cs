using System.Linq;

public static class Kata
{
  public static bool Twins(int[] arr)
  {
    return arr.GroupBy(x => x).Count(x => x.Count() == 2) == arr.Length / 2;
  }
}