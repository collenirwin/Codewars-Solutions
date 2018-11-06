using System;
using System.Linq;

public class Kata
{
  /// <summary>
  /// Returns a Boolean representing if a number with its digits concatenated an arbitrary number of times and summed is the same as the original number.</summary>
  /// <param name="number">int to be tested.</param>
  /// <param name="n">int which represents the number of times to concatenate each digit</param>
  public static bool CheckConcatenatedSum(int number, int n)
  {
    string op = number < 0 ? "-" : "";
    string numberText = Math.Abs(number).ToString();
    return numberText.Select(x => long.Parse(op + new string(x, n))).Sum() == number;
  }
}