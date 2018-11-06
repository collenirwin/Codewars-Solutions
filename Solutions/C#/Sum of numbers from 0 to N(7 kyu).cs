using System.Text;

public class SequenceSum
{
  public static string ShowSequence(int n)
  {
    if (n < 0)
    {
      return n.ToString() + "<0";
    }
    
    if (n == 0)
    {
      return "0=0";
    }
    
    var seq = new StringBuilder();
    int sum = 0;
    
    for (int x = 0; x < n; x++)
    {
      seq.Append(x);
      seq.Append("+");
      sum += x;
    }
    
    seq.Append(n.ToString() + " = " + (sum + n).ToString());
    return seq.ToString();
  }
}