using System.Linq;
using System.Text.RegularExpressions;

public static class Kata
{
  public static int CountSmileys(string[] smileys) 
  {
     return smileys.Count(x => Regex.IsMatch(x, @"[:;][-~]?[\)D]"));
  }
}