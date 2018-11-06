using System;

public class Kata
{
  public static double EvalObject(double value1, double value2, char operation)
  {
    switch(operation)
    {
      case '+': return value1 + value2;
      case '-': return value1 - value2;
      case '/': return value1 / value2;
      case '*': return value1 * value2;
      case '%': return value1 % value2;
      case '^': return Math.Pow(value1, value2);
    }
    
    return 0;
  }
}