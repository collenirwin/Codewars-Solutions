using System;

public class Cube
{
  int side;
  public int Side
  {
    get
    {
      return side;
    }
    set
    {
      side = Math.Abs(value);
    }
  }
  
  public int Surface
  {
    get
    {
      return (int)Math.Pow(Side, 2) * 6;
    }
  }
  
  public int Volume
  {
    get
    {
      return (int)Math.Pow(Side, 3);
    }
  }
  
  public Cube(int s)
  {
    Side = s;
  }
  
  public Cube() { }
}