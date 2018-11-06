using System.Linq;

public class Kata
{
  public static string Well(string[] x)
  {
    int count = x.Count(c => c == "good");
    
    if (count > 2)
    {
      return "I smell a series!";
    }
    else if (count > 0)
    {
      return "Publish!";
    }
    
    return "Fail!";
  }
}