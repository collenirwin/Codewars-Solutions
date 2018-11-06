namespace CustomAccessors 
{
  using System;
  
  public class NumericAccessor
  {
    private int _number;

    public int Number
    {
        get
        {
            return _number / 2;
        }
        set
        {
            if (value % 2 == 0)
            {
                _number = value;
            }
            else
            {
                throw new ArgumentException("value not divisble by 2");
            }
        }
    }
  }
}