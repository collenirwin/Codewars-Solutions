using System.Text.RegularExpressions;

public class Kata
{
  public static bool ValidatePin(string pin)
  {
    return (pin.Length == 4 || pin.Length == 6) && 
      Regex.Matches(pin, @"\d").Count == pin.Length;
  }
}