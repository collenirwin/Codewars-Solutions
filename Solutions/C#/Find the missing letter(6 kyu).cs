using System;

public class Kata
{
  const string ALPHA = "abcdefghijklmnopqrstuvwxyz";
  static readonly string ALPHA_UPPER = ALPHA.ToUpper();

  public static char FindMissingLetter(char[] array)
  {
    int index = ALPHA.IndexOf(array[0]);
    string alpha = ALPHA;
    if (index == -1)
    {
      alpha = ALPHA_UPPER;
      index = alpha.IndexOf(array[0]);
    }
    
    for (int x = 0; x < array.Length; x++)
    {
      char c = alpha[index + x];
      if (c != array[x])
      {
        return c;
      }
    }
    
    throw new Exception("No missing character");
  }
}