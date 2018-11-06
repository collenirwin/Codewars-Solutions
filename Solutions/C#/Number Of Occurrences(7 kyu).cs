using System.Linq;

public class OccurrencesKata
{
	public static int NumberOfOccurrences(int x, int[] xs)
  {
  	return xs.Count(a => a == x);
  }
}