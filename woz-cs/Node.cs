/* Node class for modeling graphs
 */

class Node {
  protected string name;
  protected Dictionary<string, Node> edges = new Dictionary<string, Node>();
  protected List<string> items = new List<string>();
  
  public Node (string name) {
    this.name = name;
  }
  
  public String GetName () {
    return name;
  }
  
  public void AddEdge (string name, Node node) {
    edges.Add(name, node);
  }

  public virtual Node FollowEdge (string direction) {
    return edges[direction];
  }

  public void AddItem (string item)
  {
    items.Add (item);
  }

  public void RemoveItem (string item)
  {
    items.Remove (item);
  }
  
  public bool ContainsItem (string item)
  {
    return items.Contains (item);
  }
}

