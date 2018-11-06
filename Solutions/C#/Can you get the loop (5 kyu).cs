using System.Collections.Generic;

public class Kata
{
  public static int getLoopSize(LoopDetector.Node startNode)
  {
    var list = new HashSet<LoopDetector.Node>();
    LoopDetector.Node node = startNode;
    LoopDetector.Node loopNode;
    
    while (true)
    {
      node = node.next;
    
      if (list.Contains(node))
      {
        loopNode = node;
        break;
      }
      
      list.Add(node);
    }
    
    int count = 0;
    
    while ((node = node.next) != loopNode)
    {
      count++;
    }
    
    return count + 1;
  }
}