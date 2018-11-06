using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution
{
  class Digitizer
  {
    public static long[] Digitize(long n)
    {
      return n.ToString().Reverse().Select(x => long.Parse(x.ToString())).ToArray();
    }
  }
}
11 months agoRefactor
using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution
{
  class Digitizer
  {
    public static long[] Digitize(long n)
    {
      return n.ToString()
        .ToCharArray()
        .Select(x => long.Parse(x.ToString()))
        .Reverse()
        .ToArray();
    }
  }
}