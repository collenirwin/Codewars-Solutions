using System.Linq;

public class Kata
{
  public static string[][] search_names(string[][] logins)
  {
    return logins.Where(x => x[0].EndsWith("_")).ToArray();
  }
}