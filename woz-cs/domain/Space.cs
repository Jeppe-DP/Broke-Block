/* Space class for modeling spaces (rooms, caves, ...)*/

public class Space : Node {

  public Space (String name) : base(name)
  {
  }
  Description descriptiontxt = new Description();

  public string Welcome () {
    string result = "";

    HashSet<string> exits = edges.Keys.ToHashSet();

    result += "Du er nu ved " + name + "\n\n";
    result += descriptiontxt.GetDescription (name);

    return result;
  }

  public override Space FollowEdge (string direction)
  {
 //followedge så spillet ikke slutter efter et dårlig valg
    Space next = (Space) base.FollowEdge(direction);

    return next;
  }

  // Returns just the names of the exits
  public List<string> GetExitNames()
  {
    return edges.Keys.ToList();
  }

  // Returns the actual Space objects
  public List<Space> GetExitSpaces()
  {
    return edges.Values.Cast<Space>().ToList();
  }


}
