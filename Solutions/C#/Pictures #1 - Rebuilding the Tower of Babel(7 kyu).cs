using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class Kata
{
  public static string Babel(int height)
  {
    var tower = new List<char>();
    int width = 1;

    for (int x = 0; x < height; x++)
    {
        for (int y = 0; y < 3; y++)
        {
            tower.AddRange(Enumerable.Repeat(' ', height - x - 1));
            tower.AddRange(Enumerable.Repeat('o', width));
            tower.Add('\n');
        }
        width += 2;
    }

    var builder = new StringBuilder();

    for (int x = 0; x < tower.Count - 1; x++)
    {
        builder.Append(tower[x]);
    }

    return builder.ToString();
  }
}