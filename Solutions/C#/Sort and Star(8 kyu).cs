using System;
using System.Linq;

public class Kata
{
  public static string TwoSort(string[] s)
  {
    return string.Join("***", s
      .OrderBy(x => x, StringComparer.Ordinal)
      .First()
      .ToArray());
  }  
}