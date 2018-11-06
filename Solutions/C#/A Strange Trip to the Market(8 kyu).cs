public static class Kata 
{
  public static bool IsLockNessMonster(string sentence) 
  {
    sentence = sentence.ToLower();
    return sentence.Contains("tree fiddy") || 
      sentence.Contains("three fifty") || 
      sentence.Contains("3.50");
  }
}