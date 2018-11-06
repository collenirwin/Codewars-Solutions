public static class Kata
{
  static Node getNext(int index, string[] nodes)
  {
    string node = nodes[index];
    if (node == "null")
    {
      return null;
    }
    
    return new Node(int.Parse(node), getNext(index + 1, nodes));
  }

  public static Node Parse(string nodes)
  {
    if (nodes == null || nodes == "" || nodes == "null")
    {
      return null;
    }
  
    var _nodes = nodes.Replace(" -> ", "|").Split('|');
    
    return new Node(int.Parse(_nodes[0]), getNext(1, _nodes));
  }
}