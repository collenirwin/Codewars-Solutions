public class Kata
{
  public static object PlayerRankUp(int points)
  {
    // please don't code like this
    return points > 99 
      ? (object)"Well done! You have advanced to the qualifying stage. Win 2 out of your next 3 games to rank up."
      : (object)false;
  }
}