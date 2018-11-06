using System.Linq;

public class Kata
{
  public static string FirstNonRepeatingLetter(string s)
  {
    string sLower = s.ToLower();
    int index = -1;
    
    for (int x = 0; x < sLower.Length; x++)
    {
      if (sLower.Count(l => l == sLower[x]) == 1)
      {
        index = x;
        break;
      }
    }
  
    return (index == -1) ? "" : s.Substring(index, 1);
  }
}