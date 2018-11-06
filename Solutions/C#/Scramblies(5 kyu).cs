public class Scramblies 
{
  public static bool Scramble(string str1, string str2) 
  {
    for (int x = 0; x < str2.Length; x++)
    {
      int index = str1.IndexOf(str2[x]);
      
      if (index == -1)
      {
        return false;
      }
      
      str1 = str1.Remove(index, 1);
    }
    
    return true;
  }
}