using System;
using System.Numerics;

public static class Kata
{
    public static string sumStrings(string a, string b)
    {
        if (a.Length == 0) a = "0";
        if (b.Length == 0) b = "0";
        return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
    }
}