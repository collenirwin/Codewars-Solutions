public class Kata
{
  public static bool IsAscOrder(int[] arr)
  {
    for (int x = 1; x < arr.Length; x++)
    {
      if (arr[x - 1] > arr[x])
      {
        return false;
      }
    }
    
    return true;
  }
}