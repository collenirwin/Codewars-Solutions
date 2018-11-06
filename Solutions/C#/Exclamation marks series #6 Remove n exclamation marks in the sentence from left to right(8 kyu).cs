public class Kata
{
  public static string Remove(string s, int n)
  {
    for (int x = 0; x < n; x++)
    {
      int index = s.IndexOf('!');
      
      if (index == -1)
      {
        break;
      }
      else
      {
        s = s.Remove(index, 1);
      }
    }
    
    return s;
  }
}