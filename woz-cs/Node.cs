/* Node class for modeling graphs
 */

public class Node {
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

  public void AddItem (Item item)
  {
    items.Add (item);
  }

  public Item? PickUpItem (string name)
  {
    foreach (Item item in items)
    {
      if (item.Name.Equals (name))
      {
        Item tmp = item;
        items.Remove (item);

        return tmp;
      }
    }

    return null;
  }
}

