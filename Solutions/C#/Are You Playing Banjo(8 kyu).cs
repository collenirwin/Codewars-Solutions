public class Kata
{
  public static string AreYouPlayingBanjo(string name)
  {
    return name.ToLower().Substring(0, 1) == "r"
      ? name + " plays banjo"
      : name + " does not play banjo";
  }
}