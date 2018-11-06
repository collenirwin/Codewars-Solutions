public static class Kata
{
  public static string getIssuer(long number)
  {
    string n = number.ToString();
    
    if (n.Length == 15 && (n.StartsWith("34") || n.StartsWith("37")))
    {
      return "AMEX";
    }
    
    if (n.Length == 16)
    {
      if (n.StartsWith("6011"))
      {
        return "Discover";
      }
      
      for (int x = 51; x < 56; x++)
      {
        if (n.StartsWith(x.ToString()))
        {
          return "Mastercard";
        }
      }
      
      if (n.StartsWith("4"))
      {
        return "VISA";
      }
    }
    
    if (n.Length == 13 && n.StartsWith("4"))
    {
      return "VISA";
    }
    
    return "Unknown";
  }
}