public static class Kata 
{
    public static string buildString(string[] args)
    {
      return $"I like {string.Join(", ", args)}!";
    }
}