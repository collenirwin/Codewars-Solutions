using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  static string get13thsInYear(int year)
  {
    var dates = new List<string>();
  
    for (int x = 1; x < 13; x++)
    {
      DateTime date;
      if (DateTime.TryParse($"{x}/13/{year}", out date))
      {
        if (date.DayOfWeek == DayOfWeek.Friday)
        {
          dates.Add(date.ToString("M/dd/yyyy"));
        }
      }
    }
    
    return string.Join(" ", dates);
  }

	public static string FridayTheThirteenths(int start, int end = int.MinValue)
	{
    if (end < start)
    {
      return get13thsInYear(start);
    }
    
    return string.Join(" ", 
      Enumerable.Range(start, end - start + 1).Select(x => get13thsInYear(x)));
	}
}