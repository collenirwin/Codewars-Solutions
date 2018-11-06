using System.Linq;

public class CountDig 
{
  public static int NbDig(int n, int d) 
  {
    char digit = char.Parse(d.ToString());
    
    return Enumerable.Range(0, n + 1)
      .Select(x => x * x)
      .Sum(x => x.ToString().Count(y => y == digit));
  }
}