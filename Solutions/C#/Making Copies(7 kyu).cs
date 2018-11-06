using System;
using System.Collections.Generic;

public static class ListExtensions
{
  public static List<T> Copy<T>(this List<T> lst)
  {
    return new List<T>(lst);
  }
}