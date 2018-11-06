using System.Linq;

public class Kata
{
  public static string ToCamelCase(string str)
  {
    if (str.Length < 1)
    {
      return str;
    }
  
    char delim = '_';
    str = str.Replace("-", "_");
    
    return str.Substring(0, 1) + string.Join("", str
      .Split(delim)
      .Select(x => x.Substring(0, 1).ToUpper() + (x.Length > 1 ? x.Substring(1) : "").ToLower()))
      .Substring(1);
  }
}