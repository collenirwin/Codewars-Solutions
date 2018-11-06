using System.Linq;

public class Persist 
{
	public static int Persistence(long n) 
	{
    if (n < 10)
    {
      return 0;
    }
    
    int count = 0;
    
		while (true)
    {
      n = n.ToString().Aggregate(1, (t, x) => t * int.Parse(x.ToString()));
      count++;
      
      if (n < 10)
      {
        break;
      }
    }
    
    return count;
	}
}