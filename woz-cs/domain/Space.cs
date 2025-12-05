/* Space class for modeling spaces (rooms, caves, ...)*/

namespace Domain
{
  public class Space : Node {
    Description descriptiontxt = new Description();

    public Space (String name) : base(name)
    {
    }

    public string Welcome () {
      string result = "";

      HashSet<string> exits = edges.Keys.ToHashSet();

      result += "Du er nu ved " + name + "\n\n";
      result += descriptiontxt.GetDescription (name);
      result += "\n\n" + "Nuværende udgange er:";


      foreach (String exit in exits)
      {
        result += "\n - " + exit;
      }

      return result;
    }

    public override Space FollowEdge (string direction)
    {
      Space next = (Space) base.FollowEdge(direction);

      return next;
    }
  }
}
