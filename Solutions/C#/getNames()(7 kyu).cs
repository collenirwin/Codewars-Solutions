using System.Linq;

public class Kata
{
  public static string[] GetNames(Person[] data)
  {
    return data.Select(x => x.Name).ToArray();
  }
}