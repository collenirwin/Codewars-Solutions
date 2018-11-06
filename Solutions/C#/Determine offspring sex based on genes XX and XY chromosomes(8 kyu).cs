public class Kata
{
  public static string ChromosomeCheck(string sperm)
  {
    return sperm == "XX"
      ? "Congratulations! You're going to have a daughter."
      : "Congratulations! You're going to have a son.";
  }
}