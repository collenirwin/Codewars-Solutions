public class PaddedNumbers
{
  public static string Solution(int value)
  {
    return $"Value is {value.ToString().PadLeft(5, '0')}";
  }
}