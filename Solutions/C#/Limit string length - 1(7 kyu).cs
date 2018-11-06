public class Kata
{
  public static string Limit(string text, int limit)
  {
    return text.Length <= limit ? text : text.Substring(0, limit) + "...";
  }
}