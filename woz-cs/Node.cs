/* Node class for modeling graphs
 */

class Node {
  protected string name;
  protected Dictionary<string, Node> edges = new Dictionary<string, Node>();
  protected List<Item> items = new List<Item>();
  
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

  public void AddItem (Item material)
  {
    items.Add (material);
  }
  
  public bool IsInSpace (string item)
  {
    return (item.Equals (item));
  }
}

