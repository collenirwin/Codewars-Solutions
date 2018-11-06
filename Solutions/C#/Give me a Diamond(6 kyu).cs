using System;

public class Diamond
{
	public static string print(int n)
	{
    if (n < 0 || n % 2 == 0)
    {
      return null;
    }
  
    string diamond = "";
    int halfN = n / 2 + 1;
    int stars = 1;
  
		for (int x = 1; x < halfN; x++)
    {
      diamond += new string(' ', halfN - x) + new string('*', stars) + "\n";
      stars += 2;
    }
    
    diamond += new string('*', n) + "\n";
    
    for (int x = halfN - 1; x > 0; x--)
    {
      stars -= 2;
      diamond += new string(' ', halfN - x) + new string('*', stars) + "\n";
    }
    
    return diamond;
	}
}