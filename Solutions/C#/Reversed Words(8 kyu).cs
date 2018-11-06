using System.Linq;

public class Kata
{
  public static string ReverseWords(string str)
  {
    return string.Join(" ", str.Split(' ').Reverse());
  }
}