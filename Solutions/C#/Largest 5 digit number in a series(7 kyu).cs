public class Kata 
{
  public static int GetNumber(string str) 
  {
    int largest = 0;
    
    for (int x = 0; x < str.Length - 4; x++)
    {
      int num = int.Parse(str.Substring(x, 5));
      if (num > largest)
      {
        largest = num;
      }
    }
    
    return largest;
  }
}