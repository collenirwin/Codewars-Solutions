using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable) 
  {
    // empty collection; return it
    if (iterable.ToList().Count == 0)
    {
      return iterable;
    }
  
    // List<T> for return value
    var ret = new List<T>();
    
    // grab the first T in iterable
    var last = iterable.ToList()[0];
    
    // that's always the first T in our return List
    ret.Add(last);
    
    // iterate over iterable
    foreach (var item in iterable)
    {
      // if we encount an item that differs from the last one encountered
      if (!item.Equals(last))
      {
        // add it to; we know it's unique
        ret.Add(item);
      }
      
      // set our last item
      last = item;
    }
    
    return ret;
  }
}