using System.Collections.Generic;
using System.Linq;

public static class ArrayMethods
{
  public static TSource Head<TSource>(this List<TSource> list)
  {
    return list.First();
  }
  
  public static List<TSource> Tail<TSource>(this List<TSource> list)
  {
    return list.Skip(1).ToList();
  }

  public static List<TSource> Init<TSource>(this List<TSource> list)
  {
    return list.Take(list.Count - 1).ToList();
  }
  
  public static TSource Last_<TSource>(this List<TSource> list)
  {
    return list.Last();
  }
}