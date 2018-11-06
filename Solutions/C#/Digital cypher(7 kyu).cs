using System.Linq;
using System;

public  class Kata
{
  const string ALPHA = " abcdefghijklmnopqrstuvwxyz";
  static int index = -1;
  
  static int getKey(int n)
  {
    string nums = n.ToString();
    index = index == nums.Length - 1 ? 0 : index + 1;
    
    return int.Parse(n.ToString().Substring(index, 1));
  }
  
  public static int[] Encode(string str, int n)
  {
    var encoded = str.Select(x => ALPHA.IndexOf(x) + getKey(n)).ToArray();
    index = -1;
    return encoded;
  }
}