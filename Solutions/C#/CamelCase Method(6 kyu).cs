using System.Linq;
using System.Text.RegularExpressions;

namespace Kata
{
  public static class Problem
  {
    public static string CamelCase(this string str)  
    {
      str = Regex.Replace(str.Trim(), @"\s+", " ");
    
      if (str == "")
      {
        return str;
      }
      
      return string.Join("", str
        .Split(' ')
        .Select(x => x.Substring(0, 1).ToUpper() +
          (x.Length > 1 ? x.Substring(1).ToLower() : "")));
    }
  }
}
