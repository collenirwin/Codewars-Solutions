using System;
using System.Linq;

public class MaxDiffLength 
{
    
    public static int Mxdiflg(string[] a1, string[] a2) 
    {
        return a1.Any() && a2.Any()
          ? Math.Max(Math.Abs(a1.Max(x => x.Length) - a2.Min(x => x.Length)),
              Math.Abs(a1.Min(x => x.Length) - a2.Max(x => x.Length)))
          : -1;
    }
}