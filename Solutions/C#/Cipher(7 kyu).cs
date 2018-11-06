using System.Linq;

public static class Kata
{
  public static string Encode(string str)
  {
    return string.Join("", str.Select(x => (char)(x * 6)));
  }
  
  public static string Decode(string str)
  {
    return string.Join("", str.Select(x => (char)(x / 6)));
  }
}