using System.Linq;
using System.Text.RegularExpressions;
  
public class Kata
{
  public static bool IpValidator(string ip)
  {
    return Regex.IsMatch(ip, @"^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}$") &&
      ip.Split('.').All(x => int.Parse(x) < 256);
  }
}