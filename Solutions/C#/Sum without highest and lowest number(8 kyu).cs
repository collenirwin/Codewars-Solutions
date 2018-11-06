using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  public static int Sum(int[] numbers)
  {
    if (numbers == null || numbers.Length < 3)
    {
      return 0;
    }
    
    var nums = new List<int>(numbers);
    
    nums.Remove(nums.Max());
    nums.Remove(nums.Min());
    return nums.Sum();
  }
}