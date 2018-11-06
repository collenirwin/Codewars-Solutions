using System;

public static class Kata
{
	public static double CalculateAreaOfCircle(string radius)
  {
    double r;
    if (!double.TryParse(radius, out r) || r <= 0 || radius.Contains(","))
    {
      throw new ArgumentException("radius must be numeric and above 0");
    }
  
  	return Math.Round(Math.PI * Math.Pow(r, 2), 2);
  }
}