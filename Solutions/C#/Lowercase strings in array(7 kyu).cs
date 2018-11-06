using System.Linq;

public class Kata
{
  public static object[] ArrayLowerCase(object[] arr)
  {
    return arr.Select(x => (x is string) ? (x as string).ToLower() : x).ToArray();
  }
}