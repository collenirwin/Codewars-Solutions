using System;

public class Kata
{
  private static string toHex(int num)
  {
    num = Math.Min(num, 255);
    num = Math.Max(num, 0);
    
    string symbols = "0123456789ABCDEF";
    string hex = "";

    while (num != 0)
    {
      int remainder = num % 16;
      num /= 16;
      hex = symbols[remainder] + hex;
    }

    return hex.Length > 0 ? hex.PadLeft(2, '0') : "00";
  }

  public static string Rgb(int r, int g, int b) 
  {
    return toHex(r) + toHex(g) + toHex(b);
  }
}