using System.Text.RegularExpressions;

public class Kata
{
  public static string Vowel2Index(string str)
  {
    return Regex.Replace(str, "[aeiou]", m => (m.Index + 1).ToString());
  }
}
6 months agoRefactor
using System.Text.RegularExpressions;

public class Kata
{
  public static string Vowel2Index(string str)
  {
    return Regex.Replace(str, "a|e|i|o|u", m => (m.Index + 1).ToString());
  }
}