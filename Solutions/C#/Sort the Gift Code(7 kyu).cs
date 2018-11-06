using System.Linq;

public class Kata
{
  public static string SortGiftCode(string code)
  {
    return string.Join("", code.OrderBy(x => x));
  }
}