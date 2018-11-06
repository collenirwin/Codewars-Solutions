using System;

public static class Kata
{
  public static string X(int n)
  {
    string drawing = "";
    int pos = 0;
    int delta = 1;
  
    for (int x = 0; x < n; x++)
    {
      drawing += line(pos, n);
      
      if (pos == (int)(n / 2))
      {
        delta = -1;
      }
      
      pos += delta;
    }
    
    return drawing.Trim();
  }
  
  private static string line(int pos, int n)
  {
    string line = "";
    int separation = (int)(n / 2) + 1;
  
    for (int x = 0; x < separation; x++)
    {
      line += x == pos ? "■" : "□";
    }
    
    for (int x = separation - 2; x > -1; x--)
    {
      line += x == pos ? "■" : "□";
    }
    
    return line + "\n";
  }
}