namespace Kata {
  using System;
  public static class RoundAndRound
  {
    public static decimal RoundBy2DecimalPlaces(this decimal number)
    {
        return Math.Round(number, 2, MidpointRounding.AwayFromZero);
    }
  }
}