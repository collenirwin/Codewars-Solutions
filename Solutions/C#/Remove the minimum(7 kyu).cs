using System.Collections.Generic;
using System.Linq;

public class Remover
{
  public static List<int> RemoveSmallest(List<int> numbers)
  {
    if (numbers == null || !numbers.Any())
    {
      return numbers;
    }
  
    var output = new List<int>();
    int smallest = numbers.Min();
    bool skipped = false;
    
    foreach (int number in numbers)
    {
      if (number != smallest || skipped)
      {
        output.Add(number);
      }
      else
      {
        skipped = true;
      }
    }
    
    return output;
  }
}