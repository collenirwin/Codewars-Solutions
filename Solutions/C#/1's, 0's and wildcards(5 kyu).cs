using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public List<string> Possibilities(string input)
  {
    if (!input.Contains("?"))
    {
      return new List<string>(new string[] { input });
    }
    
    string variation1 = replaceFirst(input, "0");
    string variation2 = replaceFirst(input, "1");
    return Possibilities(variation1).Concat(Possibilities(variation2)).ToList();
  }
  
  string replaceFirst(string input, string replaceWith)
  {
    int index = input.IndexOf("?");
    
    return index != -1
      ? input.Remove(index, 1).Insert(index, replaceWith)
      : input;
  }
}