using System.Linq;

class AverageSolution
{
  public static double FindAverage(double[] array)
  {
    return array.Any() ? array.Average() : 0;
  }
} 