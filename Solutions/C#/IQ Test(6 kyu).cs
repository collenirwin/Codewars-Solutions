using System.Linq;

public class IQ
{
  public static int Test(string numbers)
  { 
    var nums = numbers.Split(' ').Select(x => int.Parse(x)).ToList();
    
    if (nums.Count(x => x % 2 == 0) == 1)
    {
      return nums.IndexOf(nums.First(x => x % 2 == 0)) + 1;
    }
    
    return nums.IndexOf(nums.First(x => x % 2 == 1)) + 1;
  }
}