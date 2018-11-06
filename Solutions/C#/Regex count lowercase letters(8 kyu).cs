using System.Linq;
using System.Text.RegularExpressions;

public class Kata
{
  public static int LowercaseCountCheck(string s)
  {
    return s.Count(x => Regex.IsMatch(x.ToString(), "[a-z]"));
  }
}