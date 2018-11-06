using System;

public class Kata
{
  public static Func<int> Always(int n)
  {
    return new Func<int>(() => n);
  }
}