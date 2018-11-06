using System.Text.RegularExpressions;

public class Syntax
{
  public static string Highlight(string code)
  {
    code = Regex.Replace(code, @"(F+)", "<span style=\"color: pink\">$&</span>");
    code = Regex.Replace(code, @"(L+)", "<span style=\"color: red\">$&</span>");
    code = Regex.Replace(code, @"(R+)", "<span style=\"color: green\">$&</span>");
    code = Regex.Replace(code, @"([0-9]+)", "<span style=\"color: orange\">$&</span>");
    
    return code;
  }
}