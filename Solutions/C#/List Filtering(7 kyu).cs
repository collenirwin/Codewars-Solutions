using System.Collections.Generic;
using System.Linq;

public class ListFilterer
{
   public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
   {
      return listOfItems
        .Where(x => x.GetType() == typeof(int))
        .Cast<int>()
        .ToList<int>();
   }
}