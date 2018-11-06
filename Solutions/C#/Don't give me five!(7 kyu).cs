public class Kata
{
  public static int DontGiveMeFive(int start, int end)
  {
    int count = 0;
    
    for (int x = start; x <= end; x++)
    {
      if (!x.ToString().Contains("5"))
      {
        count++;
      }
    }
    
    return count;
  }
}