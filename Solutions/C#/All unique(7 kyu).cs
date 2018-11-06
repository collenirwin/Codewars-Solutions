using System.Linq;

namespace Code
{
  public class Unique
  {
    public static bool HasUniqueChars(string str)
    {
        return str.Distinct().Count() == str.Length;
    }
  }
}