public class Kata
{
  public static string Stringify(Node list)
  {
    string trace = "";
  
    while (list != null)
    {
      trace += list.Data + " -> ";
      list = list.Next;
    }
    
    return trace + "null";
  }
}