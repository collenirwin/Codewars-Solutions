using System.Collections.Generic;

public class SplitString
{
  public static string[] Solution(string str)
  {
    var list = new List<string>();
    
    for (int x = 1; x < str.Length; x += 2)
    {
      list.Add(str.Substring(x - 1, 2));
    }
    
    if (str.Length % 2 == 1)
    {
      list.Add(str.Substring(str.Length - 1, 1) + "_");
    }
    
    return list.ToArray();
  }
}