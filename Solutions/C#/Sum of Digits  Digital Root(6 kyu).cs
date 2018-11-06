using System;

public class Number
{
  public int DigitalRoot(long n)
  {
    if (n < 10)
    {
      return (int)n;
    }

    var nums = n.ToString();

    long ret = 0;
    for (int x = 0; x < nums.Length; x++)
    {
      ret += Convert.ToInt64(nums.Substring(x, 1));
    }

    return (int)DigitalRoot(ret);
  }
}