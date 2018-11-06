public class Kata
{
  public static string CaffeineBuzz(int n)
  {
    string output = "";
    
    if (n % 4 == 0 && n % 3 == 0)
    {
      output += "Coffee";
    }
    else if (n % 3 == 0)
    {
      output += "Java";
    }
    else
    {
      return "mocha_missing!";
    }
    
    if (n % 2 == 0)
    {
      output += "Script";
    }
    
    return output;
  }
}