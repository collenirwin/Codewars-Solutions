using System.Linq;

public class Kata
{
  public static string FakeBin(string x)
  {
    return string.Join("", 
      x.Select(n => int.Parse(n.ToString()) < 5 ? "0" : "1"));
  }
}