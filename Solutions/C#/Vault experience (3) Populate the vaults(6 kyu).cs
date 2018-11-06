using System;
using System.Collections.Generic;

public static class Vault
{
  public static List<Dweller> PopulateMyVault(int countOfDweller)
  {
    var dwellers = new List<Dweller>();

    if (countOfDweller == 0)
    {
      return dwellers;
    }
    
    dwellers.Add(new Dweller(Gender.Mr, Position.overseer));
    
    for (int x = 0; x < countOfDweller - 1; x++)
    {
      if (x % 2 == 0)
      {
        dwellers.Add(new Dweller(Gender.Mrs));
      }
      else
      {
        dwellers.Add(new Dweller(Gender.Mr));
      }
    }
    
    if (countOfDweller > 2 && countOfDweller % 2 == 1)
    {
      dwellers[2] = new Dweller(Gender.Mrs);
    }
    
    if (countOfDweller > 50)
    {
      dwellers[49] = new Dweller(Gender.Mrs, Position.overseer);
    }
    
    return dwellers;
  }
}