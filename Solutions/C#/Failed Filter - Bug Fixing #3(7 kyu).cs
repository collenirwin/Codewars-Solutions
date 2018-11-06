using System.Linq;

public class Kata
{
  public static string FilterNumbers(string str)
  {
      return string.Join("", str.Where(c => !char.IsDigit(c)));
  }
}