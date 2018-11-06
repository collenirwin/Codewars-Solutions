using System.Text.RegularExpressions;

public class Runes
{
  static string replace(string num, int replacement)
  {
    return num.Replace("?", replacement.ToString());
  }
  
  static bool leadingZero(string num)
  {
    return num.StartsWith("0") && num.Length > 1;
  }

  public static int solveExpression(string expression)
  {
    var items = Regex.Matches(expression, @"\-?[\d\?]+");
    
    string a = items[0].Value;
    string op = expression.Substring(a.Length, 1);
    string b = items[1].Value;
    string c = items[2].Value;
    
    // b consumed the - operator
    if (a.Length + b.Length + c.Length > expression.Length - 2)
    {
      b = b.Substring(1);
    }
    
    for (int x = 0; x < 10; x++)
    {
      if (!expression.Contains(x.ToString()))
      {
        string ar = replace(a, x);
        string br = replace(b, x);
        string cr = replace(c, x);
      
        if (!leadingZero(ar) && !leadingZero(br) && !leadingZero(cr))
        {
          int ai = int.Parse(ar);
          int bi = int.Parse(br);
          int ci = int.Parse(cr);
        
          if ((op == "+" && ai + bi == ci)
            || (op == "-" && ai - bi == ci)
            || (op == "*" && ai * bi == ci))
          {
            return x;
          }
        }
      }
    }
    
    return -1;
  }
}