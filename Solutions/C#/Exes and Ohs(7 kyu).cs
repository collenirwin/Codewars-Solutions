using System.Linq;

public static class Kata 
{
  public static bool XO (string input)
  {
    input = input.ToLower();
    return input.Count(x => x == 'x') == input.Count(x => x == 'o');
  }
}