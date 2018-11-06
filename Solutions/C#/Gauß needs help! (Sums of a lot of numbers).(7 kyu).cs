public class Kata
{
  public static long? RangeSum(long n)
  {
    return n > 0 ? (long?)(n * (n + 1) / 2) : null;
  }
}