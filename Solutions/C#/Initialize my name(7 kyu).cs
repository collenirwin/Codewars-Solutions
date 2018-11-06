using System.Linq;

public class Kata
{
  public static string InitializeNames(string name)
  {
    var names = name.Split(' ');
    
    if (names.Length < 3)
    {
      return name;
    }
    
    return names.First() + " " + 
      string.Join(" ", names
        .Skip(1)
        .Take(names.Length - 2)
        .Select(x => x.Substring(0, 1) + ".")) +
      " " + names.Last();
  }
}