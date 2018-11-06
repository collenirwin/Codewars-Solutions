public class Kata
{
  public static string Spam(int n)
  {
    const string SpamValue = "hue";
    string spam = "";
    
    for (int x = 0; x < n; x++)
    {
      spam += SpamValue;
    }
    
    return spam;
  }
}