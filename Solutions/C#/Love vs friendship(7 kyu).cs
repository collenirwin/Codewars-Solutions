using System.Linq;

public static class Kata
{
  const string ALPHA = "abcdefghijklmnopqrstuvwxyz";

  public static int WordsToMarks(string str)
  {
    return str.Aggregate(0, (t, x) => t + ALPHA.IndexOf(x) + 1);
  }
}