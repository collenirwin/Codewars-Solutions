using System.Linq;

public static class Kata
{
  static int numberOfOccurances(this string[] array, string occurance)
  {
    return array.Where(x => x == occurance).ToList().Count;
  }

  public static bool IsValidWalk(string[] walk)
  {
    var n = walk.numberOfOccurances("n");
    var s = walk.numberOfOccurances("s");
    var e = walk.numberOfOccurances("e");
    var w = walk.numberOfOccurances("w");
  
    return walk.Length == 10 && n == s && e == w;
  }
}