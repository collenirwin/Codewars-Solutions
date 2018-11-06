using System.Linq;

namespace Codewars
{
  public static class Challenge
  {
    public static bool IsDivisible(int n, params int[] numbers)
    {
       return numbers.All(x => n % x == 0);
    }
  }
}