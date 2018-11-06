public class LoveDetector
{
  public static bool lovefunc(int flower1, int flower2)
  {
    return !(flower1 % 2 == 0 && flower2 % 2 == 0);
  }
}