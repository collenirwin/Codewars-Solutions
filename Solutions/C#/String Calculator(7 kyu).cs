using System.Linq;

public static class Kata
{
  public static int AddStrings(string numbers)
  {
    return numbers.Replace(" ", "").Split(',').Select(x => int.Parse(x)).Sum();
  }
}