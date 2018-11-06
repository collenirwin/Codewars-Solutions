using System.Linq;

public class Kata
{
  public static int SumDigits(int number)
  {
    return number
      .ToString()
      .Replace("-", "")
      .Select(x => int.Parse(x.ToString()))
      .Sum();
  }
}