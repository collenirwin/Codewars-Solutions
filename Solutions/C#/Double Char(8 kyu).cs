public class Kata
{
  public static string DoubleChar(string s)
  {
    string ret = "";
    
    foreach (char c in s)
    {
      string letter = c.ToString();
      ret += letter + letter;
    }
    
    return ret;
  }
}