using System;

public class Kata
{
  public static string FormatTime(int hour)
  {
    string h = hour.ToString();
    
    if (h.Length < 3 || h.Length > 4)
    {
      throw new ArgumentException("Hour must be 3 to 4 digits long");
    }
    
    return h.Substring(0, h.Length - 2) + ":" + h.Substring(h.Length - 2, 2);
  }
}