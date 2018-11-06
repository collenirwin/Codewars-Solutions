using System;

public class Kata
{
  public static int ElapsedSeconds(DateTime startDate, DateTime endDate)
  {
    return (int)(endDate - startDate).TotalSeconds;
  }
}