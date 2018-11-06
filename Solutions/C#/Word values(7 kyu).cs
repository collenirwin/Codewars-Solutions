using System.Linq;

public class Kata
{
  const string ALPHA = "abcdefghijklmnopqrstuvwxyz";
  
  public static int[] WordValue(string[] a)
  {
    return a.Select((x, i) => x.Sum(y => ALPHA.IndexOf(y) + 1) * (i + 1)).ToArray();
  }
}