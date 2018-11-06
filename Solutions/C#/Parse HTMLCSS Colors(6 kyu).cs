using System;
using System.Collections.Generic;

class HtmlColorParser
{
  private readonly IDictionary<string, string> presetColors;

  public HtmlColorParser(IDictionary<string, string> presetColors)
  {
    this.presetColors = presetColors;
  }

  public RGB Parse(string color)
  {
    color = color.ToLower();
  
    if (color.StartsWith("#"))
    {
      if (color.Length == 7)
      {
        return new RGB(
          Convert.ToByte(color.Substring(1, 2), 16),
          Convert.ToByte(color.Substring(3, 2), 16),
          Convert.ToByte(color.Substring(5, 2), 16)
        );
      }
      else if (color.Length == 4)
      {
        return new RGB(
          Convert.ToByte(new string(color[1], 2), 16),
          Convert.ToByte(new string(color[2], 2), 16),
          Convert.ToByte(new string(color[3], 2), 16)
        );
      }
    }
    else if (presetColors.ContainsKey(color))
    {
      return this.Parse(presetColors[color]);
    }

    throw new ArgumentException("Invalid Color Value: " + color);
  }
}