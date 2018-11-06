using System.Linq;

public static class Kata
{
  public static string[] CapMe(string[] strings)
  {
    return strings
      .Select(x => x.Length > 1 
        ? x.Substring(0, 1).ToUpper() + x.Substring(1).ToLower() 
        : x.ToUpper())
      .ToArray();
  }
}