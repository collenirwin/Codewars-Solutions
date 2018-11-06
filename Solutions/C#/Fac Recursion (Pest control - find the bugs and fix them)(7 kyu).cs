namespace Recursion {
  using System;
  public class Fac
  {
    public int FacCalculation(int startValue)
    {
      return FacRecursion(startValue);
    }
    
    protected int FacRecursion(int value)
    {
      if (value < 0)
      {
        return 0;
      }
      
      if (value == 1 || value == 0)
      {
        return 1;
      }
      
      return FacRecursion(value - 1) * value;
    }
  }
}