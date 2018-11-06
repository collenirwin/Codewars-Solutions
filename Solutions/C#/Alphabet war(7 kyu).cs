using System.Linq;

public class Kata
{
  const string LEFT = " sbpw";
  const string RIGHT = " zdqm";

  public static string AlphabetWar(string fight)
  {
    int leftPower = fight.Aggregate(0, (t, x) => t + (LEFT.Contains(x) ? LEFT.IndexOf(x) : 0));
    int rightPower = fight.Aggregate(0, (t, x) => t + (RIGHT.Contains(x) ? RIGHT.IndexOf(x) : 0));
    
    if (leftPower > rightPower)
    {
      return "Left side wins!";
    }
    else if (leftPower < rightPower)
    {
      return "Right side wins!";
    }
    
    return "Let's fight again!";
  }
}