using System;
using System.Linq;

public static class Kata
{
  public static string Tops(string msg)
  {
    string ret = "";
    int n = 1;
    
    for (int x = 1; x < msg.Length; x += n)
    {
      n += 4;
      ret += msg.Substring(x, 1);
    }
    
    return string.Join("", ret.Reverse());
  }
}