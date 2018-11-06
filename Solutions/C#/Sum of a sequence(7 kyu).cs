using System.Linq;

public static class Kata
{
  public static int SequenceSum(int start, int end, int step)
  {
    if (start > end)
    {
      return 0;
    }
    
    int sum = 0;
    
    for (int x = start; x <= end; x += step)
    {
      sum += x;
    }
    
    return sum;
  }
}