using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static List<int> FilterOddNumber(List<int> listOfNumbers)
    {
        return listOfNumbers.Where(x => x % 2 == 1).ToList();
    }
}