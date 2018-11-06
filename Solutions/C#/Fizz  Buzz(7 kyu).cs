using System.Linq;

public class Kata
{
  public static int[] Solution(int number)
  {
    var range = Enumerable.Range(1, number - 1);
    var fizzBuzz = new int[] { 0, 0, 0 };
    
    foreach (int num in range)
    {
      if (num % 3 == 0 && num % 5 == 0)
      {
        fizzBuzz[2]++;
      }
      else if (num % 3 == 0 && num % 5 != 0)
      {
        fizzBuzz[0]++;
      }
      else if (num % 3 != 0 && num % 5 == 0)
      {
        fizzBuzz[1]++;
      }
    }
    
    return fizzBuzz;
  }
}