using System;

public static class Kata
{
  public static int Solution(int[] items, int index, int defaultValue)
  {
    return Math.Abs(index) <= items.Length
      ? index < 0 
        ? items[items.Length + index]
        : items[index]
      : defaultValue;
  }
}