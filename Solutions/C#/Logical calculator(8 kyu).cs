public class Kata
{
  public static bool LogicalCalc(bool[] array, string op)
  {
    bool output = false;
  
    if (op == "AND")
    {
      output = array[0];
      for (int x = 1; x < array.Length; x++)
      {
        output = output && array[x];
      }
    }
    else if (op == "OR")
    {
      output = array[0];
      for (int x = 1; x < array.Length; x++)
      {
        output = output || array[x];
      }
    }
    else if (op == "XOR")
    {
      output = array[0];
      for (int x = 1; x < array.Length; x++)
      {
        output = output ^ array[x];
      }
    }
    
    return output;
  }
}