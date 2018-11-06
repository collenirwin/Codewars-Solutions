using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int[] CountPositivesSumNegatives(int[] input)
    {
        return input == null || input.Length == 0
        ? new int[0]
        : new int[] { input.Count(x => x > 0), input.Where(x => x < 0).Sum() };
    }
}