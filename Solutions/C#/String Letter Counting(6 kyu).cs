using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static string StringLetterCount(string str)
  {
    var dict = new Dictionary<char, int>();
    
    foreach (char c in str.ToLower())
    {
      if (char.IsLetter(c))
      {
        if (!dict.ContainsKey(c))
        {
          dict.Add(c, 1);
        }
        else
        {
          dict[c]++;
        }
      }
    }
    
    return string.Join("", dict
      .OrderBy(x => x.Key)
      .Select(x => x.Value.ToString() + x.Key.ToString()));
  }
}