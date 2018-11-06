using System;
using System.Linq;

namespace Solution
{
  class Kata
  {
    public static int binaryArrayToNumber(int[] BinaryArray)
    {
      return BinaryArray
        .Reverse()
        .Select((x, i) => x * (int)Math.Pow(2, i))
        .Sum();
    }
  }
}