using System;
using System.Linq;

public class Revrot 
{
    public static string RevRot(string strng, int sz)
    {
        if (sz == 0 || sz > strng.Length) return "";
    
        string result = "";
        
        for (int x = 0; x < strng.Length - sz + 1; x += sz)
        {
          string chunk = strng.Substring(x, sz);
          double sum = 0;
          
          foreach (var letter in chunk)
          {
            sum += Math.Pow(double.Parse(letter.ToString()), 3);
          }
          
          if (sum % 2 == 0)
          {
            result += new string(chunk.Reverse().ToArray());
          }
          else
          {
            result += chunk.Substring(1) + chunk.Substring(0, 1);
          }
        }
        
        return result;
    }
}