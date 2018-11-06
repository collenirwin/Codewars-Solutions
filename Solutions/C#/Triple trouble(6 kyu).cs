using System;
using System.Text.RegularExpressions;

public class Kata
{
  public static int TripleDouble(long num1, long num2)
  {
    var match = Regex.Match(num1.ToString(), @"(\d)\1{2}");
    
    if (match.Success)
    {
      return Convert.ToInt32(
        Regex.IsMatch(num2.ToString(), $"({match.Value.Substring(0, 1)})" + @"\1{1}"));
    }
    
    return 0;
  }
}