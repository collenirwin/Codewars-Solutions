public class Kata
{
  public static int Divisors(int n)
  {
    if (n == 1)
    {
      return 1;
    }
    
    int divisors = 2;
    
    for (int x = 2; x < n; x++)
    {
      if (n % x == 0)
      {
        divisors++;
      }
    }
    
    return divisors;
  }
}