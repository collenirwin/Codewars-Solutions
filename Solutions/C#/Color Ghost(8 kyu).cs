using System;

public class Ghost
{
  Random ran = new Random();
  public string color { get; private set; }

  public Ghost()
  {
    color = new string[]
    {
      "white",
      "yellow",
      "purple",
      "red"
    }[ran.Next(4)];
  }
  
  // this shouldn't be here
  public string GetColor()
  {
    return color;
  }
}