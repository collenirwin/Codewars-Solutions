public class Kata
{
  public static double[] Averages(int[] numbers)
  {
    if (numbers == null || numbers.Length < 2)
    {
      return new double[0];
    }
    
    var array = new double[numbers.Length - 1];
    
    for (int x = 0; x < array.Length; x++)
    {
      array[x] = (numbers[x] + numbers[x + 1]) / 2.0;
    }
    
    return array;
  }
}