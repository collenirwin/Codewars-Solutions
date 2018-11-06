using System.Linq;

public static class Kata
{
  public static string FormatWords(string[] words)
  {
    var all = words?.Where(x => x != "").ToArray();
    
    if (!all?.Any() ?? true)
    {
      return "";
    }
    
    if (all.Length == 1)
    {
      return all[0];
    }
    
    return $"{string.Join(", ", all.Take(all.Length - 1))} and {all.Last()}";
  }
}