using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class Vault
{
  public static string HackMyTerminal(int passLength, string machineCode)
  {
    if (passLength < 1 || machineCode == null)
    {
      return null;
    }
  
    var matches = Regex.Matches(machineCode, "[a-z]{" + passLength.ToString() + "}", RegexOptions.IgnoreCase)
      .OfType<Match>()
      .Select(x => x.Value)
      .ToList();
    
    if (!matches.Any())
    {
      return null;
    }
    
    string password = matches[0];
    
    foreach (var match in matches)
    {
      bool sameLetter = false;
      for (int x = 0; x < match.Length; x++)
      {
        if (matches.Count(m => match.Substring(x, 1) == m.Substring(x, 1)) > 1)
        {
          sameLetter = true;
          break;
        }
      }
      
      if (!sameLetter)
      {
        return match;
      }
    }
    
    return null;
  }
}