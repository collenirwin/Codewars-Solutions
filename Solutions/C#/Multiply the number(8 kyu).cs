using System;

public class Kata
{
  public static int Multiply(int number)
  {
    return number * (int)Math.Pow(5, number.ToString().Replace("-", "").Length);
  }
}