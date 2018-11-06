using System.Linq;
using System.Text.RegularExpressions;

public class Kata
{
  public static int SumOfIntegersInString(string s)
  {
    return Regex.Matches(s, @"\d+").Cast<Match>().Sum(x => int.Parse(x.Value));
  }
}