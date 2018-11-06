using System;

public static class Kata
{
  public static bool CheckCoupon(string enteredCode, string correctCode, 
    string currentDate, string expirationDate)
  {
    return enteredCode == correctCode &&
      DateTime.Parse(currentDate) <= DateTime.Parse(expirationDate);
  }
}