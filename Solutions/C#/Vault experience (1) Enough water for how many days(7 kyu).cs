using System;
using System.Linq;

public static class Vault
{
    public static int ThirstyIn(int water, int[] ageOfDweller)
    {
        if (ageOfDweller.Length == 0) return -1;
    
        return (int)(water / (ageOfDweller.Count(x => x < 18) 
          + (ageOfDweller.Count(x => x > 17 && x < 51) * 2)
          + (ageOfDweller.Count(x => x > 50) * 1.5)));
    }
}