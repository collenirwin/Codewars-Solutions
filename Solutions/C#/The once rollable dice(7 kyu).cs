using System;

public class Character
{
  Random ran = new Random();
  public string Name;
  public int Opness;

  public Character(string name, int opness)
  {
    this.Name = name;
    this.Opness = opness;
  }
  
  public int Attack()
  {
    return ran.Next(1, 21) + this.Opness;  // Chosen by fair d20 roll
                                                    // Guaranteed to be random
  }
}