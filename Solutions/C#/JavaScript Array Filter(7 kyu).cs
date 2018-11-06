using System.Linq;

public class Kata
{
  public static int[] GetEvenNumbers(int[] numbers)
  {
    return numbers.Where(x => x % 2 == 0).ToArray();
  }
}