using System;

public class Cube
{
  private int Side;
  
  public Cube(int side)
  {
    SetSide(side);
  }
  
  public Cube() : this(0) { }
  
  public int GetSide()
  {
    return this.Side;
  }
  
  public void SetSide(int s)
  {
    this.Side = Math.Abs(s);
  }
}