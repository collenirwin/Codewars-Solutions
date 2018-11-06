using System;

public static class Kata
{
  public static int[] ReverseSeq(int n)
  {
    var nums = new int[n];
    
    for (int x = n; x > 0; x--)
    {
      nums[n - x] = x;
    }
    
    return nums;
  }
}