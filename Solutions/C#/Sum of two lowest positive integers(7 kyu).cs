using System.Linq;

public static class Kata
{
	public static int sumTwoSmallestNumbers(int[] numbers)
	{
		return numbers.OrderBy(x => x).Take(2).Sum();
	}
}