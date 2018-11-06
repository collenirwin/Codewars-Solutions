using System.Linq;

class Solution 
{
  public static int Stray(int[] numbers)
  {
    if (numbers.Count(x => x == numbers[0]) == 1)
    {
      return numbers[0];
    }
  
    return numbers.Single(x => x != numbers[0]);
  }
}