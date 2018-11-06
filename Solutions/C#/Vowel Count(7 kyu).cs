using System;
using System.Linq;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        var vowels = "aeiou";

        return str.Count(x => vowels.Contains(x));
    }
}