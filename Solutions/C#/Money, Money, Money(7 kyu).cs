using System;

public class Kata
{
  public static int CalculateYears(double principal, 
    double interest, double tax, double desiredPrincipal)
  {
    if (principal >= desiredPrincipal)
    {
      return 0;
    }
    
    int years = 0;
    while (principal < desiredPrincipal)
    {
      double addedInterest = principal * interest;
      principal += addedInterest - (addedInterest * tax);
      years++;
    }
    
    return years;
  }
}