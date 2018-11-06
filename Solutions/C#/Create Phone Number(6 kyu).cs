using System.Linq;

public class Kata
{
  public static string CreatePhoneNumber(int[] n)
  {
    string first3 = string.Join("", n.Take(3));
    string second3 = string.Join("", n.Skip(3).Take(3));
    string last = string.Join("", n.Skip(6));
    
    return $"({first3}) {second3}-{last}";
  }
}