using System;

public class NthSeries
{
  public static string seriesSum(int n)
  {
    if (n == 0)
    {
      return "0.00";
    }
  
    double div = 4;
    double output = 1.0;
    
    for (int x = 0; x < n - 1; x++)
    {
      output += 1 / div;
      div += 3;
    }
    
    return Math.Round(output, 2).ToString("n2");
  }
}