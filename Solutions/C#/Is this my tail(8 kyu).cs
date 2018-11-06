public class Kata
{
  public static bool CorrectTail(string body, string tail)
  {
    return body.Substring(body.Length - tail.Length) == tail;
  }
}