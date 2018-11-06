public class Kata
{
  public static string MyFirstInterpreter(string code)
  {
    int cell = 0;
    string output = "";
    
    foreach (char command in code)
    {
      if (command == '+')
      {
        cell = cell == 255 ? 0 : cell + 1;
      }
      else if (command == '.')
      {
        output += ((char)cell).ToString();
      }
    }
    
    return output;
  }
}