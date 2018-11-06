using System.Linq;

namespace Solution
{
  public static class ArraysInversion
  {
    public static int[] InvertValues(int[] input)
    {
      return input.Select(x => -x).ToArray();
    }
  }
}