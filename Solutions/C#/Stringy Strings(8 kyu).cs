public class Kata
{
  public static string Stringy(int size)
  {
    string stringy = "";
  
    for (int x = 1; x < size + 1; x++)
    {
      stringy += (x % 2).ToString();
    }
    
    return stringy;
  }
}