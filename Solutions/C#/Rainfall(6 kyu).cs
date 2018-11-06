using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Rainfall 
{
    static IEnumerable<double> getNumbers(string town, string strng)
    {
        strng = strng
            .Split('\n')
            .FirstOrDefault(x => x.StartsWith(town + ":"));
             
        if (strng == null)
        {
            return null;
        }
        
        return Regex.Matches(strng, @"\d+\.\d+")
            .OfType<Match>()
            .Select(x => double.Parse(x.Value));
    }

    public static double Mean(string town, string strng) 
    {
        return getNumbers(town, strng)?.Average() ?? -1;
    }
    
    public static double Variance(string town, string strng) 
    {
        var numbers = getNumbers(town, strng);
        
        if (numbers == null)
        {
            return -1;
        }
        
        double avg = numbers.Average();
        
        return numbers.Select(x => Math.Pow(x - avg, 2)).Average();
    }
}