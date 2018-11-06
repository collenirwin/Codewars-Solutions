using System.Linq;

public class Kata
{
  public static string PigIt(string str)
  {
    return string.Join(" ", str
      .Split(' ')
      .Select(x => x.Length == 1 ? x : x.Substring(1) + x.Substring(0, 1) + "ay"));
  }
}