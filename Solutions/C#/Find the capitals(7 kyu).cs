using System.Linq;

public static class Kata
{
  public static int[] Capitals(string word)
  {
		return word
      .Select((x, i) => char.IsUpper(x) ? i : -1)
      .Except(new int[] { -1 })
      .ToArray();
  }
}