using System.Linq;

namespace Extensions
{
  public static class StringExt
  {
    public static string ToAlternatingCase(this string s)
    {
      return string.Join("", 
        s.Select(x => char.IsUpper(x) ? char.ToLower(x) : char.ToUpper(x)));
    }
  }
}