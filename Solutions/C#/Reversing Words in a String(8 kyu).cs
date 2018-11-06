using System.Linq;

public class Kata
{
  public static string Reverse(string text)
  {
    return string.Join(" ", text.Trim().Split(' ').Reverse());
  }
}