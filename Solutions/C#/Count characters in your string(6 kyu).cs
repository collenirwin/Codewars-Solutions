using System.Collections.Generic;

public class Kata
{
  public static Dictionary<char, int> Count(string str)
  {
    var dict = new Dictionary<char, int>();
    
    foreach (char c in str)
    {
      if (!dict.ContainsKey(c))
      {
        dict.Add(c, 0);
      }
      
      dict[c]++;
    }
    
    return dict;
  }
}