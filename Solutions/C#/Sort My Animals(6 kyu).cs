using System.Collections.Generic;
using System.Linq;

namespace Kata
{
  public class Animal
  {
    public string Name { get; set; }
    public int NumberOfLegs { get; set; }
  }

  public class AnimalSorter
  {
    public List<Animal> Sort(List<Animal> input)
    {
      if (input == null)
      {
        return null;
      }
      
      return input.OrderBy(x => x.NumberOfLegs).ThenBy(x => x.Name).ToList();
    }
  }
}