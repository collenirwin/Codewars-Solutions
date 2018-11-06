public class Kata
{
  public static string AbbrevName(string name)
  {
    var names = name.ToUpper().Split(' ');
    return names[0].Substring(0, 1) + "." + names[1].Substring(0, 1);
  }
}