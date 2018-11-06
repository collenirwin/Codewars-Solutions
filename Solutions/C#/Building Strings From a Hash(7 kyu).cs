using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  public static string StringifyDict<TKey, TValue>(Dictionary<TKey, TValue> hash)
  {
    return string.Join(",", hash.Keys.Select(x => $"{x} = {hash[x]}"));
  }
}