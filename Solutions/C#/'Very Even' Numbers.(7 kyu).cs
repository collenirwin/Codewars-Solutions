using System.Linq;

public class Kata
{
  public static bool IsVeryEvenNumber(int number)
  {
      if (number % 2 == 1)
      {
          return false;
      }
      
      if (number.ToString().Length == 1)
      {
          return true;
      }
  
      return IsVeryEvenNumber(number.ToString().Select(x => int.Parse(x.ToString())).Sum());
  }
}