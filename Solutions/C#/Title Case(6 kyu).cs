using System.Linq;

public class Kata
{
  public static string TitleCase(string title, string minorWords="")
  {
    var minor = minorWords?.ToLower().Split(' ') ?? new string[0];
  
    string output = string.Join(" ", title
      .Split(' ')
      .Select((x) => 
      {
        x = x.ToLower();
        return minor.Contains(x)
          ? x
          : x.Substring(0, 1).ToUpper() + (x.Length > 1 ? x.Substring(1) : "");
      }));
      
    return output.Length > 1
      ? output.Substring(0, 1).ToUpper() + output.Substring(1)
      : output.ToUpper();
  }
}