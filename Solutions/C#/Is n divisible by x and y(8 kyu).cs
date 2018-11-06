public class DivisibleNb
{
	public static bool isDivisible(long n, long x, long y)
  {
    return n % x == 0 && n % y == 0;
	}
}