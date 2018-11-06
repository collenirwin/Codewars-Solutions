using System;
using System.Linq;

public class Smallfuck
{
  public static string Interpreter(string code, string tape)
  {
    int index = 0;
    var tapeArray = tape.Select(x => int.Parse(x.ToString())).ToArray();
    
    for (int x = 0; x < code.Length; x++)
    {
      if (index >= tapeArray.Length || index < 0)
      {
        break;
      }
      
      char command = code[x];
      
      if (command == '>')
      {
        index++;
      }
      else if (command == '<')
      {
        index--;
      }
      else if (command == '*')
      {
        tapeArray[index] = Math.Abs(tapeArray[index] - 1);
      }
      else if (command == '[' && tapeArray[index] == 0)
      {
        int count = 1;
        while (count > 0)
        {
          x++;
          if (code[x] == '[')
          {
            count++;
          }
          else if (code[x] == ']')
          {
            count--;
          }
        }
      }
      else if (command == ']' && tapeArray[index] != 0)
      {
        int count = 1;
        while (count > 0)
        {
          x--;
          if (code[x] == '[')
          {
            count--;
          }
          else if (code[x] == ']')
          {
            count++;
          }
        }
      }
    }
    
    return string.Join("", tapeArray);
  }
}