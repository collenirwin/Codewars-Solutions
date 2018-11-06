using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static IEnumerable<string> OpenOrSenior(int[][] data)
  {
    var list = new List<string>();
    
    foreach (var person in data)
    {
      if (person[0] > 54 && person[1] > 7)
      {
        list.Add("Senior");
      }
      else
      {
        list.Add("Open");
      }
    }
    
    return list.ToArray();
  }
}